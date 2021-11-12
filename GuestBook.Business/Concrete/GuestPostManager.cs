using AutoMapper;
using FluentValidation;
using GuestBook.Business.Abstract;
using GuestBook.Core.Dtos.GuestPost;
using GuestBook.DataAccess.Abstract;
using GuestBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Business.Concrete
{
    public class GuestPostManager : IGuestPostService
    {
        private readonly IMapper _mapper;
        private readonly IValidator<GuestPostCreateDto> _createValidator;
        private readonly IValidator<GuestPostUpdateDto> _updateValidator;
        private readonly IGuestPostDal _guestPostDal;

        public GuestPostManager(IMapper mapper, IValidator<GuestPostCreateDto> createValidator, IValidator<GuestPostUpdateDto> updateValidator, IGuestPostDal guestPostDal)
        {
            _mapper = mapper;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
            _guestPostDal = guestPostDal;
        }

        public GuestPostDto Add(GuestPostCreateDto guestPost)
        {
            var validate = _createValidator.Validate(guestPost);
            if (validate.IsValid)
            {
                var data = _guestPostDal.Add(_mapper.Map<GuestPost>(guestPost));
                return _mapper.Map<GuestPostDto>(data);
            }
            return null;
        }

        public void Delete(int id)
        {
            var data = _guestPostDal.GetById(id);
            if (data != null)
                _guestPostDal.Delete(data);

        }

        public List<GuestPostListDto> GetAll()
        {
            var list = _guestPostDal.GetAll();
            // var result = _mapper.Map<IEnumerable<GuestPostListDto>(list);
            var data = new List<GuestPostListDto>();

            foreach (var item in list)
            {
                data.Add(new GuestPostListDto
                {
                    CreatedDate = item.CreatedDate, 
                    Email = item.Email, 
                    Id = item.Id,   
                    LastName = item.LastName,   
                    Name = item.Name,   
                    PostContent = item.PostContent,
                });
            }

            return data;        

        }

        public GuestPostDto GetById(int id)
        {
            var data = _guestPostDal.GetById(id);
            if (data != null)
                return _mapper.Map<GuestPostDto>(data);
            return null;
        }

        public GuestPostDto Update(GuestPostUpdateDto guestPost)
        {
            var valid = _updateValidator.Validate(guestPost);
            if (valid.IsValid)
            {
                var entitiy = _mapper.Map<GuestPost>(guestPost);
                var addEntity = _guestPostDal.Add(entitiy);

                return _mapper.Map<GuestPostDto>(addEntity);

            }
            return null;

        }
    }
}

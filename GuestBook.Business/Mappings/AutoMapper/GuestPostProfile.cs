using AutoMapper;
using GuestBook.Core.Dtos.GuestPost;
using GuestBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Business.Mappings.AutoMapper
{
    public class GuestPostProfile:Profile
    {
        public GuestPostProfile()
        {
            CreateMap<GuestPost, GuestPostCreateDto>().ReverseMap();
            CreateMap<GuestPost, GuestPostDto>().ReverseMap();
            CreateMap<GuestPost, GuestPostListDto>().ReverseMap();
            CreateMap<GuestPost, GuestPostUpdateDto>().ReverseMap();

        }
    }
}

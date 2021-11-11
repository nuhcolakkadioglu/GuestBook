using GuestBook.Core.Dtos.GuestPost;
using GuestBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Business.Abstract
{
    public interface IGuestPostService
    {
        GuestPostListDto GetAll();
        GuestPostDto GetById(int id);
        GuestPostDto Add(GuestPostCreateDto guestPost);
        GuestPostDto Update(GuestPostUpdateDto guestPost);
        void DeleteById(int id);
    }
}

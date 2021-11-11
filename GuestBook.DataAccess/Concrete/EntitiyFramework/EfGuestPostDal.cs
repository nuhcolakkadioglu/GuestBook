using GuestBook.Core.DataAccess.EntityFramework;
using GuestBook.DataAccess.Abstract;
using GuestBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.DataAccess.Concrete.EntitiyFramework
{
    public class EfGuestPostDal : EfEntityRepositoryBase<GuestPost,GuestPostContext>, IGuestPostDal
    {
       
        
    }
}

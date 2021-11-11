using GuestBook.Core.DataAccess;
using GuestBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.DataAccess.Abstract
{
    public interface IGuestPostDal: IEntitiyRepository<GuestPost>
    {

    }
}

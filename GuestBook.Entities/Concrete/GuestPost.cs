using GuestBook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Entities.Concrete
{
    public class GuestPost:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; }
        public string PostContent { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
    }
}

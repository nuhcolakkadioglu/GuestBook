using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Core.Dtos.GuestPost
{
    public class GuestPostDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PostContent { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

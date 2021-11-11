using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Core.Dtos.GuestPost
{
    public class GuestPostUpdateDto:GuestPostCreateDto
    {
        public int Id { get; set; }
    }
}

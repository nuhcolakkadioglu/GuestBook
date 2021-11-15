using GuestBook.Core.Entities;

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
        //ben master 
        //dneemee
    }
}

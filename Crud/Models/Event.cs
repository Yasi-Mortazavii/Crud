using System.Collections.Generic;

namespace Crud.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public ICollection<EventImage> EventImages { get; set; }
    }
}

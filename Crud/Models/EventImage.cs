namespace Crud.Models
{
    public class EventImage
    {

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}

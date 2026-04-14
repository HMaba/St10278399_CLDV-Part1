using System.ComponentModel.DataAnnotations;

namespace CloudPart1.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required]
        public string EventName { get; set; }

       
        public DateTime EventDate { get; set; } = DateTime.Now;

        public string? Description { get; set; }

        public int? VenueID { get; set; }
        public Venue? Venue { get; set; }
    }
}

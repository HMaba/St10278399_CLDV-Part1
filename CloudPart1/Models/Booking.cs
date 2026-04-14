using System.ComponentModel.DataAnnotations;

namespace CloudPart1.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required]
        public int EventID { get; set; }
        public Event? Event { get; set; }

        [Required]
        public int VenueID { get; set; }
        public Venue? Venue { get; set; }

        public string? PhoneNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}

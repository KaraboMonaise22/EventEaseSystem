using System.ComponentModel.DataAnnotations;

namespace EventEaseSystem.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }
        [Required]
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Event>Events { get; set; } = new List<Event>();
    }
}

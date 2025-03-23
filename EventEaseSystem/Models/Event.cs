using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventEaseSystem.Models
{
    public class Event
    {

        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        
        [ForeignKey("Venue")]
        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}

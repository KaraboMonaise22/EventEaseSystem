using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventEaseSystem.Models
{
    public class Booking
    {
        [Key]    
        public int BookingId { get; set; } // Primary Key

        
        [ForeignKey("Event")]
        public int? EventId { get; set; } // Foreign Key to Event
        public Event? Event { get; set; }

        
        [ForeignKey("Venue")]
        public int? VenueId { get; set; } // Foreign Key to Venue
        public Venue? Venue { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BookingDate { get; set; } // Date and time of booking

        
       
       
    }
}

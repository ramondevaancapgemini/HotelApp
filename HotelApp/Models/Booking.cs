using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Guest ID")]
        public int GuestId{ get; set; }
        public Guest Guest { get; set; }
        [DisplayName("Room ID")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [DisplayName("From")]
        public DateTime Start { get; set; }
        [DisplayName("To")]
        public DateTime End { get; set; }
        [DisplayName("Payment received")]
        public bool PayedFor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Room type")]
        public RoomType RoomType { get; set; }
        [DisplayName("Room size")]
        public RoomSize RoomSize { get; set; }
        [DisplayName("Room status")]
        public RoomStatus RoomStatus { get; set; }
    }

    public enum RoomType {
        LUXURIOUS = 0,
        REGULAR = 1,
        BUDGET = 2
    };
    public enum RoomSize {
        ONE_PERSON = 0,
        TWO_PERSON = 1,
        THREE_FOUR_PERSON = 2,
        FIVE_SIX_PERSON = 3
    };
    public enum RoomStatus {
        OPERATIONAL = 0,
        BLOCKED = 1
    };
}

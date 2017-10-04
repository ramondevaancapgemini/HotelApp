using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Given name")]
        public string FirstName { get; set; }
        [DisplayName("Surname prefix")]
        public string SurnamePrefix { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }
        [DisplayName("ZIP code")]
        public string ZipCode { get; set; }

        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email address")]
        public string Email { get; set; }
    }
}

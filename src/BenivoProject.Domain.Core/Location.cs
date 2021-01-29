using System;
using System.ComponentModel.DataAnnotations;

namespace BenivoProject.Domain.Core
{
    public class Location : BaseEntity
    {
        [MaxLength(150)]
        public string Country { get; set; }
        [MaxLength(150)]
        public string Region { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        public DateTime CreationDate { get; set; }

        public string FullAddress
        {
            get
            {
                return Country + (string.IsNullOrEmpty(Region)?"":", " + Region)  + (string.IsNullOrEmpty(City) ? "" : ", " + City);
            }
        }
    }
}

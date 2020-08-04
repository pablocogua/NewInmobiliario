using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Models
{
    public class Property
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public PropertyType propertyType { get; set; }
        [Required]
        public long PropertyPrice { get; set; }
        [Required]
        public PropertyAddress propertyAddress { get; set; }
        [Required]
        public Byte status { get; set; }
        [Required]
        public BusinessType businessType { get; set; }
        [Required]
        public int Stratum { get; set; }
        [Required]
        public string BuiltArea { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int ParkingLots { get; set; }
        [Required]
        public Byte isNew { get; set; }

    }
}

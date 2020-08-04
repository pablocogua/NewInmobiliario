using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Models
{
    public class PropertyAddress
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int countryId { get; set; }
        [Required]
        public int departmentId { get; set; }
        [Required]
        public int cityId { get; set; }
    }
}

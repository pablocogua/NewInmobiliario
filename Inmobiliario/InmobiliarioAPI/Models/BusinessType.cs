using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Models
{
    public class BusinessType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string businessType { get; set; }
    }
}

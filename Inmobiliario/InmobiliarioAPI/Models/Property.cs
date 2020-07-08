using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Models
{
    public class Property
    {
        public Guid Id { get; set; }
        public PropertyType propertyType { get; set; }
        public decimal PropertyPrice { get; set; }
    }
}

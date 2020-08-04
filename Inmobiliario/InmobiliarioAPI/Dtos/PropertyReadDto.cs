using InmobiliarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Dtos
{
    public class PropertyReadDto
    {   
        public Guid Id { get; set; }
        
        public PropertyType propertyType { get; set; }
        
        public long PropertyPrice { get; set; }
        
        public PropertyAddress propertyAddress { get; set; }
        
        public Byte status { get; set; }
        
        public BusinessType businessType { get; set; }
        
        public int Stratum { get; set; }
        
        public string BuiltArea { get; set; }
        
        public int Rooms { get; set; }
        
        public int Bathrooms { get; set; }
       
        public int ParkingLots { get; set; }
        
        public Byte isNew { get; set; }
    }
}

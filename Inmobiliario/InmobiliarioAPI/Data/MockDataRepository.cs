using InmobiliarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Data
{
    public class MockDataRepository : IPropertiesRepository
    {
        public IEnumerable<Property> GetProperties()
        {
            var properties = new List<Property>
            {
                new Property { Id = new Guid(), propertyType = new PropertyType { Id = 1, PropertyTypeName = "Casa" }, PropertyPrice = 50000000 },
                new Property { Id = new Guid(), propertyType = new PropertyType { Id = 2, PropertyTypeName = "Lote" }, PropertyPrice = 60000000 }
            };
            return properties;
        }

        public Property GetPropertyById(Guid Id)
        {
            return new Property { Id = new Guid(), propertyType = new PropertyType { Id = 1, PropertyTypeName = "Casa" }, PropertyPrice = 50000000 };
        }
    }
}

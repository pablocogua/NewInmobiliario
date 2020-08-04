using InmobiliarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Data
{
    public interface IPropertiesRepository
    {
        IEnumerable<Property> GetProperties();
        Property GetPropertyById(Guid Id);
    }
}

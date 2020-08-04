using InmobiliarioAPI.Models;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Data
{
    public class SqlPropertiesRepository : IPropertiesRepository
    {
        private readonly InmobiliarioContext _context;

        public SqlPropertiesRepository(InmobiliarioContext context)
        {
            _context = context;
        }

        public IEnumerable<Property> GetProperties()
        {
            return _context.Properties.ToList();
        }

        public Property GetPropertyById(Guid Id)
        {
            return _context.Properties.FirstOrDefault(x => x.Id == Id);
        }
    }
}

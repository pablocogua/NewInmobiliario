using InmobiliarioAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Data
{
    public class InmobiliarioContext : DbContext
    {
        public InmobiliarioContext(DbContextOptions<InmobiliarioContext> opt) : base(opt)
        {

        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<PropertyAddress> propertyAddresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InmobiliarioAPI.Data;
using InmobiliarioAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliarioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InmoController : ControllerBase
    {
        private MockDataRepository _data;

        public InmoController(MockDataRepository data = null)
        {
            _data = data == null ? new MockDataRepository() : data;
        }

        [HttpGet]
        public IEnumerable<Property> Get()
        {
            return _data.GetProperties();
        }
    }
}

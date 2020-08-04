using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InmobiliarioAPI.Data;
using InmobiliarioAPI.Dtos;
using InmobiliarioAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IPropertiesRepository _repository;
        private readonly IMapper _mapper;

        public PropertiesController(IPropertiesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/properties
        [HttpGet]
        public ActionResult<IEnumerable<PropertyReadDto>> GetAllProperties()
        {
            var properties = _repository.GetProperties();
            return Ok(_mapper.Map<IEnumerable<PropertyReadDto>>(properties));
        }
        
        //GET api/properties/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Property>> GetPropertyById(Guid id)
        {
            var property = _repository.GetPropertyById(id);
            if (property != null)
            {
                return Ok(_mapper.Map<PropertyReadDto>(property));
            }
            return NotFound();
        }
    }
}

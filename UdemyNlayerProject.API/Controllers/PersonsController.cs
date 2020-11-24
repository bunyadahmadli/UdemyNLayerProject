using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Service;

namespace UdemyNlayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _service;
        private readonly IMapper _mapper;

        public PersonsController(IMapper mapper, IService<Person> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _service.GetAllAsync();

            return Ok(persons);
        }
    }
}

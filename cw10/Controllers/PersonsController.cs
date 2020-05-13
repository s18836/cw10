using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonsController : ControllerBase
    {

        private readonly PeopleDbContext _context;

        public PersonsController(PeopleDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_context.People.ToList());
        }


    }
}
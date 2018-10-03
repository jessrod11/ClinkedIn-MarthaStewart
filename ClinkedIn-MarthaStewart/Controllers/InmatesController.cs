using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_MarthaStewart.Clink;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn_MarthaStewart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        //Methods
        [HttpGet("{id}/services")]
        public IActionResult InmateServeUs(int id)
        {
            // instatiating a new class
            var clink = new TheClink();

            // setting a variable to the method in the class to get an inmate by id
            var inmateService = clink.GetById(id);

            // returning the services out of getting a partaicular inmate by id
            return Ok(inmateService.Services);
        }

    }
}
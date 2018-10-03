using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_MarthaStewart.Clink;
using ClinkedIn_MarthaStewart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn_MarthaStewart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        //Methods
        [HttpGet ("")]
         public ActionResult<IEnumerable<Inmate>> GetAll()
        {
            var clink = new TheClink();
            var allInmates = clink.GetAllInmates();
            return Ok(allInmates);
        }
        
     
        [HttpGet("{interest}")]
        public ActionResult<IEnumerable<Inmate>> GetInmatesByInterest(string interest)
        {
            var clink = new TheClink();
            var inmatesByInterest = clink.GetAllInmates().Where(inmate => inmate.Interests.Any(i => interest.ToLower() == i.ToLower()));
            return Ok(inmatesByInterest);
        }

        
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
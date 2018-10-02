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
        [HttpGet ("{id}/services"]
        // other code
        [HttpGet("interest")]
        public ActionResult<IEnumerable<Inmate>> GetInmatesByInterest(string interest)
        {
            var clink = new TheClink();
            var inmatesByInterest = clink.GetAllInmates().Where(inmate => inmate.Interests.Contains(interest));
            return Ok(inmatesByInterest);


        }

    }
}
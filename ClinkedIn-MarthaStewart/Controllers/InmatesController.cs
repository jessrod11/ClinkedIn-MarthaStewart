using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        //Methods
        [HttpGet]
        public ActionResult<IEnumerable<InmatesController>> GetAll()
        {
            return Inmate;
        }

    }
}
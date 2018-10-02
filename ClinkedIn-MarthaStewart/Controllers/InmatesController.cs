using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_MarthaStewart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn_MarthaStewart.TheClink;

namespace ClinkedIn_MarthaStewart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        //Methods
        [HttpGet ("{id}/services"]
        public IActionResult InmateServeUs(int id)
        {
            var clink = new TheClink.GetById(id);
            return Inmate.service;
        }
    }
}
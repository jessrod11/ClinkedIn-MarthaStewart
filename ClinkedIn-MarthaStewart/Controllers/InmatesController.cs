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
        [HttpGet]
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

        [HttpPut("{id}/newservice")]
        public IActionResult AddNewService(int id, Service service)
        {

            var clink = new TheClink();
            var inmateToAddServiceTo = clink.GetById(id);

            if (inmateToAddServiceTo == null) return NotFound();

            inmateToAddServiceTo.Services.Add(service);
            return Ok(inmateToAddServiceTo.Services);
        }

        [HttpDelete("{id}/deleteservice")]
        public IActionResult DeleteService(int id, Service service)
        {
            var clink = new TheClink();
            var inmateToHaveServiceDeleted = clink.GetById(id);

            if (inmateToHaveServiceDeleted == null) return NotFound();

            var serviceToBeRemoved = inmateToHaveServiceDeleted.Services.Find(s => s.Name == service.Name);
           
            inmateToHaveServiceDeleted.Services.Remove(serviceToBeRemoved);
            return Ok(inmateToHaveServiceDeleted.Services);
        }

        [HttpPut("{id}/newinterest/{interest}")]
        public IActionResult AddNewInterest(int id, string interest)
        {
            var clink = new TheClink();
            var inmateWithInterests = clink.GetById(id);

            if (inmateWithInterests == null) return NotFound();

            inmateWithInterests.Interests.Add(interest);
            return Ok(inmateWithInterests.Interests);
        }

        [HttpDelete("{id}/newinterest/{interest}")]
        public IActionResult DeleteInterest(int id, string interest)
        {
            var clink = new TheClink();
            var inmateWithLostInterests = clink.GetById(id);

            if (inmateWithLostInterests == null) return NotFound();

            inmateWithLostInterests.Interests.Remove(interest);
            return Ok(inmateWithLostInterests.Interests);
        }

        [HttpGet("{id}/friends")]
        public IActionResult InmatesFriends(int id)
        {
            var clink = new TheClink();
            var inmatesAmigos = clink.GetById(id);
            return Ok(inmatesAmigos.Friends);
        }

        [HttpGet("{id}/suggested")]
        public IActionResult FriendsOfFriends (int id)
        {
            var clink = new TheClink();
            var self = clink.GetAllInmates().FirstOrDefault(inmate => inmate.Id == id);
            if (self == null)
            {
                return NotFound();
            }
            var suggestions = self
                .Friends
                .SelectMany(friend => friend.Friends)
                .Where(inmate => inmate != self && !self.Friends.Contains(inmate))
                .ToHashSet();
            return Ok(suggestions);
        }

        [HttpGet("{id}/enemies")]
        public IActionResult InmatesEnemies(int id)
        {
            var clink = new TheClink();
            var inmatesEnemigos = clink.GetById(id);
            return Ok(inmatesEnemigos.Enemies);
        }


        [HttpPost]
        public IActionResult AddNewInmate (Inmate newInmate)
        {
            var clink = new TheClink();
            var inmateList = clink.GetAllInmates();
            newInmate.Id = inmateList.Any() ? inmateList.Max(thisGuy => thisGuy.Id) + 1 : 1;
            clink.Add(newInmate);
            return Ok(newInmate.Id);
        }

    }
}
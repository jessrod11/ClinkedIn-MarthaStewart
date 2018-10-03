using ClinkedIn_MarthaStewart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_MarthaStewart.Clink
{
    public class TheClink
    {
        static List<Inmate> _theClink = new List<Inmate>
        {

            new Inmate()
            {
                Id = 0,
                Name = "Nico Bellic",
                Age = 25,
                Gender = Gender.Male,
                Crime = "Grand Theft Auto",
                Interests = new List<string>{ "cars", "boxing", "cigars", "hairgel" },
                Services = new List<Service>{
                    new Service() { Name = "Foot massage", Price = 5.05},
                    new Service() { Name = "Hair cut", Price = 20}
                }
            },

            new Inmate()
            {
                Id= 2,
                Name = "Crazy Eyes",
                Age = 30,
                Gender = Gender.Female,
                Crime = "Kidnapping",
                Interests = new List<string> {"books", "teddy bears", "candy", "Beyonce"},
                Services = new List<Service>
                {
                    new Service() {Name = "Counseling", Price = 2.25},
                    new Service() {Name = "Singing", Price = 1.00 }
                }
                
            }
        };

        internal List<Inmate> GetAll()
        {
            return _theClink;
        }

        internal void Add(Inmate inmate)
        {
            inmate.Id = _theClink.Any() ? _theClink.Max(thisGuy => thisGuy.Id) + 1 : 1;
            _theClink.Add(inmate);
        }

        internal Inmate GetById(int id)
        {
            return _theClink.FirstOrDefault(inmate => inmate.Id == id);
        }
    }
}

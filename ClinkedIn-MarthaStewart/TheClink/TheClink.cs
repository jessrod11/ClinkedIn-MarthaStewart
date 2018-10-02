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
                Id = 1,
                Name = "Stabs McGee",
                Age = 31,
                Gender = Gender.Male,
                Crime = "stabbin'",
                Services = new List<Service>()
                {
                    new Service() { Name = "prison tattoo", Price = 25 },
                    new Service() { Name = "acupuncture", Price = 10 }
                },
                Interests = new List<string>()
                {
                    "whittling",
                    "gift wrapping"
                }
            }
        };

        internal void Add(Inmate inmate)
        {
            inmate.Id = _theClink.Any() ? _theClink.Max(thisGuy => thisGuy.Id) + 1 : 1;
            _theClink.Add(inmate);
        }

        public Inmate GetById(int id)
        {
            return _theClink.FirstOrDefault(inmate => inmate.Id == id);
        }
    }
}

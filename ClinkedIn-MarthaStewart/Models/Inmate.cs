using ClinkedIn_MarthaStewart.Clink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_MarthaStewart.Models
{
    public class Inmate
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Crime { get; set; }
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List <Service> Services {get; set;} = new List<Service>();
        public List<string> Interests { get; set; } = new List<string>();
        public List<Inmate> Friends { get; set; } = new List<Inmate>();
        public List<Inmate> Enemies { get; set; } = new List<Inmate>();
    }
}

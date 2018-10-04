﻿using ClinkedIn_MarthaStewart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_MarthaStewart.Clink
{
    public class TheClink
    {
        static List<Inmate> _theClink = new List<Inmate>();

        static TheClink()
        {
            var nico = new Inmate()
            {
                Id = 0,
                Name = "Nico Bellic",
                Age = 25,
                Gender = Gender.Male,
                Crime = "Grand Theft Auto",
                Interests = new List<string> { "cars", "boxing", "cigars", "hairgel", "books" },
                Services = new List<Service>{
                    new Service() { Name = "Foot massage", Price = 5.05},
                    new Service() { Name = "Hair cut", Price = 20}
                }
            };
            var pablo = new Inmate()
            {
                Id = 0,
                Name = "Pablo Escobar",
                Age = 37,
                Gender = Gender.Male,
                Crime = "Drug Smuggling",
                Interests = new List<string> { "cars", "drugs", "cigars", "dancing" },
                Services = new List<Service>{
                    new Service() { Name = "Foot massage", Price = 5.05},
                    new Service() { Name = "Hair cut", Price = 20}
                }
            };
            var scarface = new Inmate()
            {
                Id = 0,
                Name = "Tony \"Scarface\" Montana",
                Age = 40,
                Gender = Gender.Male,
                Crime = "Organized Crime",
                Interests = new List<string> { "cars", "cocaine", "nightclubbing", "hairgel" },
                Services = new List<Service>{
                    new Service() { Name = "Foot massage", Price = 5.05},
                    new Service() { Name = "Hair cut", Price = 20}
                }
            };

            var stabs = new Inmate()
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
                    "gift wrapping",
                    "cars"
                }
            };

            var crazyEyes = new Inmate()
            {
                Id = 2,
                Name = "Crazy Eyes",
                Age = 30,
                Gender = Gender.Female,
                Crime = "Kidnapping",
                Interests = new List<string> { "books", "teddy bears", "candy", "Beyonce" },
                Services = new List<Service>
                {
                    new Service() {Name = "Counseling", Price = 2.25},
                    new Service() {Name = "Singing", Price = 1.00 }
                }

            };

            var wormy = new Inmate()
            {
                Id = 4,
                Name = "Wormy",
                Age = 46,
                Gender = Gender.Male,
                Crime = "repeat offender of urinating in public",
                Interests = new List<string> { "peeing on things", "Irish dance music", "slinkys" },
                Services = new List<Service>
                {
                    new Service () { Name = "water bed provider", Price = 69.99},
                    new Service () { Name = "showers of gold", Price = 0.50}
                }
            };


            nico.Friends.Add(stabs);
            nico.Friends.Add(wormy);
            nico.Friends.Add(pablo);
            nico.Enemies.Add(crazyEyes);
            nico.Enemies.Add(scarface);

            stabs.Friends.Add(nico);
            stabs.Friends.Add(scarface);
            stabs.Enemies.Add(pablo);
            stabs.Enemies.Add(crazyEyes);
            stabs.Enemies.Add(wormy);

            crazyEyes.Enemies.Add(nico);
            crazyEyes.Enemies.Add(wormy);
            crazyEyes.Enemies.Add(stabs);
            crazyEyes.Friends.Add(pablo);
            crazyEyes.Friends.Add(scarface);

            wormy.Friends.Add(nico);
            wormy.Friends.Add(pablo);
            wormy.Enemies.Add(scarface);
            wormy.Enemies.Add(stabs);
            wormy.Enemies.Add(crazyEyes);

            _theClink.Add(nico);
            _theClink.Add(stabs);
            _theClink.Add(crazyEyes);
            _theClink.Add(wormy);

        }


        internal void Add(Inmate inmate)
        {
            _theClink.Add(inmate);
        }

        internal Inmate GetById(int id)
        {
            return _theClink.FirstOrDefault(inmate => inmate.Id == id);
        }

        public IEnumerable<Inmate> GetAllInmates()
        {
            return _theClink;
        }
    }
}

﻿using ClinkedIn_MarthaStewart.Models;
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
            new Inmate() {Name = "", Age = "", Crime = "", Gender = "", Id = "", Interests = new List<string>}
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

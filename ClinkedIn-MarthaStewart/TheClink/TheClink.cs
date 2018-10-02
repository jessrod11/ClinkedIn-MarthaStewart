using ClinkedIn_MarthaStewart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_MarthaStewart.TheClink
{
    public class TheClink
    {
        static List<Inmate> _theClink = new List<Inmate>();

        internal void Add(Inmate inmate)
        {
            inmate.Id = _theClink.Any() ? _theClink.Max(thisGuy => thisGuy.Id) + 1 : 1;
            _theClink.Add(inmate);
        }

        internal Inmate GetById(int id)
        {
            return _theClink.First(inmate => inmate.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_AnonymousTypes
{
    class Planet
    {
        public string Name { get; }
        public int NumFromSun { get; }
        public string EquatorLength { get; }
        public Planet PreviousPlanet { get; }

        public Planet(string name, int numFromsun, string equatorLength, Planet previousPlanet)
        {
            Name = name;
            NumFromSun = numFromsun;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}

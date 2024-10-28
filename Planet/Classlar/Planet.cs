using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helper;

namespace Planets.Classlar
{
    public class Planet
    {
        public int PlanetId { get; set; }
        public string PlanetName { get; set; }
        public double PlanetArea { get; set; }

        public Planet(string planetName, double planetArea)
        {
            PlanetName = planetName;
            PlanetArea = planetArea;
        }
    }
}

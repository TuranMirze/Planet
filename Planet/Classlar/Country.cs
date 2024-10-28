using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helper;
namespace Planets.Classlar
{
    public class Country
    {

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public double CountryArea { get; set; }
        public string CountryAnthem { get;   set; }
        public Region region { get; set; }
 
        public Country(string countryName, double countryArea, string countryAnthem)
        {
            CountryName = countryName;
            CountryArea = countryArea;
            CountryAnthem = countryAnthem;
        }


    }
}

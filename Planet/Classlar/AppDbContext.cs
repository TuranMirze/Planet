using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Classlar;
using Core.Helper;
using System.Numerics;

public class AppDbContext
{
    static private List<Country> countries = new List<Country>();
    static private List<Planet> planets = new List<Planet>();
    Region reg;


    public void CreateCountry(Country country)
    {
        countries.Add(country);
    }

    public void CreatePlanet(Planet planet)
    {
        planets.Add(planet);
    }


    public void UpdateCountry(int countryId, Country updatedCountry)
    {

        var country = countries.FirstOrDefault(x => x.CountryId == countryId);
        if (country != null)
        {

            country.CountryName = updatedCountry.CountryName;
            country.CountryArea = updatedCountry.CountryArea;
            country.CountryAnthem = updatedCountry.CountryAnthem;
            country.region = updatedCountry.region;
        }
    }

    public void UpdatePlanet(int planetId, Planet updatedPlanet)
    {

        var planet = planets.FirstOrDefault(x => x.PlanetId == planetId);
        if (planet != null)
        {
            planet.PlanetName = updatedPlanet.PlanetName;
            planet.PlanetArea = updatedPlanet.PlanetArea;

        }
    }

    public void RemoveCountry(int countryId)
    {

        var countryToRemove = countries.FirstOrDefault(x => x.CountryId == countryId);
        if (countryToRemove != null)
        {
            countries.Remove(countryToRemove);
            Console.WriteLine($"Olke (ID: {countryId}) silindi.");
        }
        else
        {
            Console.WriteLine("Olke tapilmadi.");
        }
    }


    public void RemovePlanet(int planetId)
    {

        var planetToRemove = planets.FirstOrDefault(x => x.PlanetId == planetId);
        if (planetToRemove != null)
        {
            planets.Remove(planetToRemove);
            Console.WriteLine($"Planet (ID: {planetId}) silindi.");
        }
        else
        {
            Console.WriteLine("Planet tapilmadi.");
        }
    }




    public List<Country> GetAllCountry()
    {
        return countries.ToList();
    }

    public List<Planet> GetAllPlanet()
    {
        return planets.ToList();
    }

    public bool GetPlanet(string name)
    {
        bool f = false;
        foreach (Planet planets in planets)
        {
            if (planets.PlanetName.Equals(name))
            {
                f = true;
            }
        }
        return f;
    }


    public void GetCountryByRegion(Region region)
    {
        foreach (var item in countries)
        {
            if (item.region == region)
            {
                Console.WriteLine();
                Console.WriteLine("Sira:" + item.CountryId + " ");
                Console.WriteLine("Olke:" + item.CountryName + " ");
                Console.WriteLine("Himn:" + item.CountryAnthem + " ");
                Console.WriteLine("Bolge:" + item.region);
                Console.WriteLine();
            }



            else
            {

                Console.WriteLine($"{item.region} qitesinde olke yoxdur. Yaxinda A101de :)");

            }
        }
    }
}





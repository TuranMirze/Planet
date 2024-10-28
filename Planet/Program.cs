using Planets.Classlar;
using System;
using System.Numerics;
using Core.Helper;
using Planets.Classlar;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            bool f = false;
            do
            {
                Console.WriteLine("******Menu******");
                Console.WriteLine("0. Cixis");
                Console.WriteLine("1. Sisteme giris");
                Console.WriteLine();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        f = true;
                        Console.WriteLine("Exit");
                        break;

                    case "1":
                        bool f2 = false;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Planet yarat (Haşa yaratmaq Allaha mexsusdur)");
                            Console.WriteLine("2. Butun Planetleri gor");
                            Console.WriteLine("3. Planet sec");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine();
                            string choose1 = Console.ReadLine();

                            switch (choose1)
                            {
                                case "1":
                                    Console.WriteLine("Planet adini daxil edin:");
                                    string planetName = Console.ReadLine();
                                    Console.WriteLine("Planet sahesini daxil edin:");
                                    double planetArea = double.Parse(Console.ReadLine());


                                    Planet planet = new Planet(planetName, planetArea);
                                    context.CreatePlanet(planet);

                                    break;


                                case "2":
                                    List<Planet> planets = context.GetAllPlanet();

                                    if (planets.Count > 0)
                                    {
                                        Console.WriteLine("Butun Planetler:");
                                        foreach (var item in planets)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"No: {item.PlanetId++}, Name: {item.PlanetName} Area: {item.PlanetArea}");
                                            Console.WriteLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Heç bir planet yoxdur.");
                                        Console.WriteLine();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Planet secin");
                                    string PlanetName = Console.ReadLine();
                                    bool f3 = false;

                                    if (context.GetPlanet(PlanetName) == true)
                                    {
                                        Console.WriteLine("Var bele planet. Xosgeldinizzz");

                                        do
                                        {
                                            Console.WriteLine($"Planet: {PlanetName}");
                                            Console.WriteLine("1. Olke yarat");
                                            Console.WriteLine("2. Olkelri gor");
                                            Console.WriteLine("3. Evvelki menuya qayit.");
                                            Console.WriteLine("0. Exit");

                                            string choose2 = Console.ReadLine();
                                            switch (choose2)
                                            {
                                                case "1":
                                                    Console.Write("Olkenin adını daxil edin: ");
                                                    string countryName = Console.ReadLine();
                                                    Console.Write("Olkenin qitesini daxil edin: ");
                                                    double countryArea = double.Parse(Console.ReadLine());
                                                    Console.Write("Olkenin himnini yazin: ");
                                                    string countryAnthem = Console.ReadLine();


                                                    Country country = new Country(countryName, countryArea, countryAnthem);
                                                    context.CreateCountry(country);
                                                    Console.WriteLine("Yeni olke quruldu.");
                                                    break;

                                                case "2":
                                                    List<Country> countries = context.GetAllCountry();
                                                    if (countries.Count > 0)
                                                    {
                                                        foreach (var item in countries)
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine($"No: {item.CountryId + 1}, Name: {item.CountryName},Area:{item.CountryArea} Anthem: {item.CountryAnthem}");
                                                            Console.WriteLine();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine();
                                                        Console.WriteLine("Olke yoxdur.");
                                                        Console.WriteLine();
                                                    }
                                                    break;

                                                case "3":
                                                    f3 = true;
                                                    break;

                                                case "0":
                                                    f2 = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("Yanlis secim!!! Tekrar yoxlayin.");
                                                    break;
                                            }
                                        } while (!f3);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Planet yoxdu baboo");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Yanlis secim!!! Tekrar yoxlayin.");
                                    break;
                            }

                        } while (!f2);
                        break;
                }


            } while (!f);

        }
    }
}

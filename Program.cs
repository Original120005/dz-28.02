using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz28_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string> {
                { "Англия", "England" },
                { "Германия", "Germany"},
                { "Австрия", "Austria" },
                { "Франция", "France"},
                { "Норвегия", "Norway" },
                { "Испания", "Spain"},
                { "Бельгия", "Belgium" },
                { "Украина", "Ukraine"},
                { "Швеция", "Sweden" } };

            Console.WriteLine("Choose language:\t1. parussian\t2. English");
            string l = Console.ReadLine();
            int language = Convert.ToInt32(l);
            string country;
            switch (language)
            {
                case 1:
                    Console.Write("Введите страну: ");
                    country = Console.ReadLine();
                    if (countries.ContainsKey(country))
                    {
                        Console.WriteLine($"{country} - {countries[country]}");
                    }
                    else { Console.WriteLine("Такого в словаре нет :("); }
                    break;

                case 2:
                    Console.Write("Enter country: ");
                    country = Console.ReadLine();
                    foreach (var key in countries.Keys)
                    {
                        if (countries[key] == country)
                        {
                            Console.WriteLine($"{countries[key]} - {key}");
                        }
                    }
                    break;
            }


        }
    }
}

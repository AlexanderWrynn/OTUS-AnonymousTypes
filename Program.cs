using System;

namespace OTUS_AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program 1
            var planetVenus = new
            {
                name = "Venus",
                numFromSun = 2,
                equatorLength = "230094344,16 km",
                previousPlanet = "null"
            };

            var planetEarth = new
            {
                name = "Earth",
                numFromSun = 3,
                equatorLength = "255600981,16 km",
                previousPlanet = planetVenus
            };

            var planetMars = new
            {
                name = "Mars",
                numFromSun = 4,
                equatorLength = "72471355,37 km",
                previousPlanet = planetEarth
            };

            var planetVenusAgain = new
            {
                name = "Venus",
                numFromSun = 2,
                equatorLength = "230094344,16 km",
                previousPlanet = planetMars
            };

            Console.WriteLine($"{planetVenus.name}\n{planetVenus.numFromSun}\n" +
                $"{planetVenus.equatorLength}\n{planetVenus.previousPlanet}\n" +
                $"Equals: {planetVenus.Equals(planetVenus)}\n");

            Console.WriteLine($"{planetEarth.name}\n{planetEarth.numFromSun}\n" +
                $"{planetEarth.equatorLength}\n{planetEarth.previousPlanet}\n" +
                $"Equals: {planetVenus.Equals(planetEarth)}\n");

            Console.WriteLine($"{planetMars.name}\n{planetMars.numFromSun}\n" +
                $"{planetMars.equatorLength}\n{planetMars.previousPlanet}\n" +
                $"Equals: {planetVenus.Equals(planetMars)}\n");

            Console.WriteLine($"{planetVenusAgain.name}\n{planetVenusAgain.numFromSun}\n" +
                $"{planetVenusAgain.equatorLength}\n{planetVenusAgain.previousPlanet}\n" +
                $"Equals: {planetVenus.Equals(planetVenusAgain)}\n");

            Console.WriteLine("________________________");
            Console.WriteLine();

            //Program 2
            var planets = new PlanetsCatalog();
            planets.GetPlanet("Earth");
            planets.GetPlanet("Лимпопо");
            planets.GetPlanet("Venus");
            planets.GetPlanet(null);

            Console.WriteLine("________________________");
            Console.WriteLine();

            //Program 3
            planets.GetPlanet("Earth", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }
                return null;
            });

            planets.GetPlanet("Лимпопо", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }
                return null;
            });

            planets.GetPlanet("Venus", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }
                return null;
            });

            planets.GetPlanet(null, (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }
                return null;
            });

            Console.WriteLine("________________________");
            Console.WriteLine();

            //Program 3*
            planets.GetPlanet("Earth", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }

                int counter = 0;
                for (int i = 0; i < planets.catalog.Count; i++)
                {
                    if (string.Equals(name, planets.catalog[i].Name))
                        counter++;
                }

                switch (counter) 
                {
                    case > 0:
                        return null;
                    default:
                        Console.WriteLine("Это запретная планета");
                        return "The X-Files theme";
                }
            });

            planets.GetPlanet("Лимпопо", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }

                int counter = 0;
                for (int i = 0; i < planets.catalog.Count; i++)
                {
                    if (string.Equals(name, planets.catalog[i].Name))
                        counter++;
                }

                switch (counter)
                {
                    case > 0:
                        return null;
                    default:
                        Console.WriteLine("Это запретная планета");
                        return "The X-Files theme";
                }
            });

            planets.GetPlanet("Mars", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Введена пустая строка");
                    return "Mistake";
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто");
                    return "Mistake";
                }

                int counter = 0;
                for (int i = 0; i < planets.catalog.Count; i++)
                {
                    if (string.Equals(name, planets.catalog[i].Name))
                        counter++;
                }

                switch (counter)
                {
                    case > 0:
                        return null;
                    default:
                        Console.WriteLine("Это запретная планета");
                        return "The X-Files theme";
                }
            });

            Console.ReadKey(true);

        }
    }
}

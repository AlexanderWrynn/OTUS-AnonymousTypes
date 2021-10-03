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

            var firstEarth = planets.GetPlanet("Earth");
            var firstLimpopo = planets.GetPlanet("Limpopo");
            var firstMars = planets.GetPlanet("Mars");
            var firstNull = planets.GetPlanet(null);

            OutputTupleData(firstEarth);
            OutputTupleData(firstLimpopo);
            OutputTupleData(firstMars);
            OutputTupleData(firstNull);

            Console.WriteLine("________________________");
            Console.WriteLine();

            //Program 3
            var secondEarth = planets.GetPlanet("Earth", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

                return null;

            });

            var secondLimpopo = planets.GetPlanet("Limpopo", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

                return null;

            });

            var secondMars = planets.GetPlanet("Mars", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

                return null;

            });

            var secondNull = planets.GetPlanet(null, (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

                return null;

            });

            OutputTupleData(secondEarth);
            OutputTupleData(secondLimpopo);
            OutputTupleData(secondMars);
            OutputTupleData(secondNull);

            Console.WriteLine("________________________");
            Console.WriteLine();

            //Program 3*
            var thirdEarth = planets.GetPlanet("Earth", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

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
                        return "Это запретная планета *The X-Files theme*";
                }
            });

            var thirdLimpopo = planets.GetPlanet("Limpopo", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

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
                        return "Это запретная планета *The X-Files theme*";
                }
            });

            var thirdMars = planets.GetPlanet("Mars", (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

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
                        return "Это запретная планета *The X-Files theme*";
                }
            });

            var thirdNull = planets.GetPlanet(null, (name, count) =>
            {
                if (string.IsNullOrEmpty(name))
                    return "Введена пустая строка";

                if (count % 3 == 0)
                    return "Вы спрашиваете слишком часто";

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
                        return "Это запретная планета *The X-Files theme*";
                }
            });

            OutputTupleData(thirdEarth);
            OutputTupleData(thirdLimpopo);
            OutputTupleData(thirdMars);
            OutputTupleData(thirdNull);

            Console.ReadKey(true);

        }

        public static void OutputTupleData((string, int?, string, string) tuple)
        {
            string auxiliaryString = "";

            if (tuple.Item1 != null)
                auxiliaryString += tuple.Item1 + ", ";

            if (tuple.Item2 != null)
                auxiliaryString +=  tuple.Item2 + ", ";

            if (tuple.Item3 != null)
                auxiliaryString +=  tuple.Item3 + ", ";

            if (tuple.Item4 != null)
                auxiliaryString +=  tuple.Item4 + ", ";

            Console.WriteLine(auxiliaryString.Trim(' ').Trim(',')); ;
        }
    }
}

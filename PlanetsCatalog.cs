using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_AnonymousTypes
{
    class PlanetsCatalog
    {
        internal List<Planet> catalog = new List<Planet>();
        internal int count = 0;

        public PlanetsCatalog()
        {
            catalog.Add(new Planet("Venus", 2, "230094344,16 km", null));
            catalog.Add(new Planet("Earth", 3, "255600981,16 km", catalog[0]));
            catalog.Add(new Planet("Mars", 4, "72471355,37 km", catalog[1]));
        }

        public void GetPlanet(string name)
        {
            int numCoincidence = 0;
            count++;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Введена пустая строка");
                return;
            }

            if (count % 3 == 0)
            {
                Console.WriteLine("Вы спрашиваете слишком часто");
                return;
            }

            for (int i = 0; i < catalog.Count; i++)
            {
                if (string.Equals(name, catalog[i].Name))
                {
                    Console.WriteLine($"Порядковый номер: {catalog[i].NumFromSun}; " +
                        $"Длина экватора: {catalog[i].EquatorLength}");
                    numCoincidence++;
                }
            }

            if (numCoincidence == 0)
                Console.WriteLine("Не удалось найти планету");
        }

        public void GetPlanet(string name, PlanetValidator planetValidator)
        {
            int numCoincidence = 0;
            count++;

            if (planetValidator(name, count) != null)
                return;

                for (int i = 0; i < catalog.Count; i++)
                {
                    if (string.Equals(name, catalog[i].Name))
                    {
                        Console.WriteLine($"Порядковый номер: {catalog[i].NumFromSun}; " +
                            $"Длина экватора: {catalog[i].EquatorLength}");
                        numCoincidence++;
                    }
                }

            if (numCoincidence == 0)
                Console.WriteLine("Не удалось найти планету");
        }

        public delegate string PlanetValidator(string name, int count);
    }
}

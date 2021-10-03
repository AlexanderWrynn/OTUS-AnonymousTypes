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

        public (string, int?, string, string) GetPlanet(string name)
        {
            count++;

            if (string.IsNullOrEmpty(name))
            {
                return (null, null, null, "Введена пустая строка");
            }

            if (count % 3 == 0)
            {
                return (null, null, null, "Вы спрашиваете слишком часто");
            }

            for (int i = 0; i < catalog.Count; i++)
            {
                if (string.Equals(name, catalog[i].Name))
                {
                    return (catalog[i].Name, catalog[i].NumFromSun,
                            catalog[i].EquatorLength, null);
                }
            }

            return (null, null, null, "Не удалось найти планету");
        }

        public (string, int?, string, string) GetPlanet(string name, PlanetValidator planetValidator)
        {
            count++;

            if (planetValidator(name, count) != null)
                return (null, null, null, planetValidator(name, count));

            for (int i = 0; i < catalog.Count; i++)
            {
                if (string.Equals(name, catalog[i].Name))
                {
                    return (catalog[i].Name, catalog[i].NumFromSun,
                            catalog[i].EquatorLength, null);
                }
            }

            return (null, null, null, "Не удалось найти планету");
        }

        public delegate string PlanetValidator(string name, int count);
    }
}

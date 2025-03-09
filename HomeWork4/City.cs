using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class City(int citizens)
    {
        private int _citizens = citizens;

        public int Citizens { get => _citizens; set => _citizens = value; }

        public static City operator +(City city, int count) => new(city.Citizens + count);

        //public static City operator +(City city_1, City city_2) => new(city_1.Citizens + city_2.Citizens);

        public static City operator -(City city, int count) => new(city.Citizens - count);

        //public static City operator -(City city_1, City city_2) => new(city_1.Citizens - city_2.Citizens);

        public static bool operator ==(City city_1, City city_2) => (city_1.Citizens == city_2.Citizens);
        public static bool operator !=(City city_1, City city_2) => !(city_1.Citizens != city_2.Citizens);
        //public static bool operator >(City city_1, City city_2) => (city_1.Citizens > city_2.Citizens);
        //public static bool operator <(City city_1, City city_2) => (city_1.Citizens < city_2.Citizens);

        //public static bool operator ==(City city_1, int count) => (city_1.Citizens == count);
        //public static bool operator !=(City city_1, int count) => !(city_1.Citizens != count);
        public static bool operator >(City city_1, int count) => (city_1.Citizens > count);
        public static bool operator <(City city_1, int count) => (city_1.Citizens < count);

    }
}

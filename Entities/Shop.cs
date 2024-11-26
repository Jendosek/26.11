using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Shop
    {
        private double _area;

        public Shop()
        {
            _area = 0;
        }

        public Shop(double area)
        {
            _area = area;
        }

        public double Area
        {
            get
            {
                return _area;
            }
            set
            {
                if (value > 0)
                {
                    _area = value;
                }
                else
                {
                    Console.WriteLine("Площа має бути більше 0!");
                }
            }
        }

        public static Shop operator +(Shop shop, double area)
        {
            shop.Area += area;
            return shop;
        }

        public static Shop operator -(Shop shop, double area)
        {
            shop.Area -= area;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Area != shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Shop otherShop)
            {
                return this.Area == otherShop.Area;
            }
            else
            {
                Console.WriteLine("Об'єкт не є типу Shop!");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Площа магазину: {_area}";
        }
    }
}

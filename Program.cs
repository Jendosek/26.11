using ConsoleApp3.Entities;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Shop shop1 = new Shop(100);
            Shop shop2 = new Shop(210);

            Console.WriteLine($"Площа магазину №1: {shop1.Area}");
            Console.WriteLine($"Площа магазину №2: {shop2.Area}");
            Console.WriteLine();

            shop1 += 50;
            shop2 -= 50;
            Console.WriteLine($"Площа магазину №1 після додавання: {shop1.Area}");
            Console.WriteLine();
            Console.WriteLine($"Площа магазину №2 після віднімання: {shop1.Area}");
            Console.WriteLine();

            Console.WriteLine($"Порівняємо площі магазинів");
            if(shop1 == shop2)
            {
                Console.WriteLine("Площі магазинів рівні");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Площі магазинів не рівні");
                Console.WriteLine("Порівняємо яка площа є більшою");
                if (shop1 > shop2)
                {
                    Console.WriteLine("Площа магазину №1 більша за площу магазину №2");
                }
                else
                {
                    Console.WriteLine("Площа магазину №2 більша за площу магазину №1");
                }
            }
            Console.WriteLine();

        }
    }
}

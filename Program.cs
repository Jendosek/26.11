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

            Journal journal1 = new Journal(10);
            Journal journal2 = new Journal(15);

            Console.WriteLine($"Кількість працівників в журналі №1: {journal1.EmployeeCount}");
            Console.WriteLine($"Кількість працівників в журналі №2: {journal2.EmployeeCount}");
            Console.WriteLine();

            journal1 += 5;
            journal2 -= 5;
            Console.WriteLine($"До журнала №1 додано 5 працівників");
            Console.WriteLine($"Кількість працівників в журналі №1 після змін: {journal1.EmployeeCount}");
            Console.WriteLine();
            Console.WriteLine($"З журнала №2 віднято 5 працівників");
            Console.WriteLine($"Кількість працівників в журналі №2 після змін: {journal2.EmployeeCount}");
            Console.WriteLine();

            Console.WriteLine("Перевіримо чи журнали мають окрему кількість працівників");
            if (journal1 == journal2)
            {
                Console.WriteLine("Кількість працівників в журналах однакова");
            }
            else
            {
                Console.WriteLine("Кількість працівників в журналах різна");
                Console.WriteLine("Перевіримо чи кількість працівників в журналі №1 більша за кількість працівників в журналі №2");
                if (journal1 > journal2)
                {
                    Console.WriteLine("Працівників в журналі №1 більше ніж в журналі №2");
                }
                if (journal1 < journal2)
                {
                    Console.WriteLine("Працівників в журналі №1 менше ніж в журналі №2");
                }
            }
            Console.WriteLine();

            









        }
    }
}

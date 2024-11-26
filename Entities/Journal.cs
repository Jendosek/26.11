using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Journal
    {
        private int _employeeCount = 0;

        public Journal()
        {
            _employeeCount = 0;
        }

        public Journal(int employeeCount)
        {
            _employeeCount = employeeCount;
        }

        public int EmployeeCount
        {
            get
            {
                return _employeeCount;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кільксть працівників не може бути від'ємною!");
                }
                _employeeCount = value;
            }
        }

        public static Journal operator +(Journal journal, int employeeCount)
        {
            journal._employeeCount += employeeCount;
            return journal;
        }

        public static Journal operator -(Journal journal, int employeeCount)
        {
            journal._employeeCount -= employeeCount;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1._employeeCount == journal2._employeeCount;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1._employeeCount != journal2._employeeCount;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1._employeeCount > journal2._employeeCount;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1._employeeCount < journal2._employeeCount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Journal otherJournal)
            {
                return this.EmployeeCount == otherJournal.EmployeeCount;
            }
            else
            {
                Console.WriteLine("Об'єкт не є типу Journal!");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Кількість працівників: {_employeeCount}";
        }

    }
}

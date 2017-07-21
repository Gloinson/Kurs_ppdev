using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInPraxis
{
    public delegate string MyDelegate(int i, double d);

    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetData();

            var criteria = 5;
            Console.WriteLine("The worst ones");
            foreach (var e in Abfrage(employees, delegate (Employee e) { return e.Experience < criteria; }))
                Console.WriteLine($"Id: {e.Id,2} - {e.Name,20} - {e.Experience,5}");

            var criteria2 = 10;
            Console.WriteLine("The bad ones");
            foreach (var e in Abfrage(employees, e => e.Experience > criteria && e.Experience < criteria2 ))
                Console.WriteLine($"Id: {e.Id, 2} - {e.Name, 20} - {e.Experience, 5}");

            Console.WriteLine("The good ones");
            foreach (var e in employees.Where(e => e.Experience > criteria2))
                Console.WriteLine($"Id: {e.Id,2} - {e.Name,20} - {e.Experience,5}");

            Console.ReadLine();
        }

        private static IEnumerable<Employee> Abfrage(IEnumerable<Employee> employees, Predicate<Employee> eval)
        {
            foreach (var e in employees)
                if (eval(e))
                    yield return e;
        }

        private static IEnumerable<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Hans", Experience = 5 },
                new Employee { Id = 2, Name = "Lisa", Experience = 3 },
                new Employee { Id = 3, Name = "Maria", Experience = 6 },
                new Employee { Id = 4, Name = "Anna", Experience = 10 },
                new Employee { Id = 5, Name = "Thomas", Experience = 14 },
                new Employee { Id = 6, Name = "Stanislaus", Experience = 8 },
                new Employee { Id = 7, Name = "Luis", Experience = 2 },
                new Employee { Id = 8, Name = "Andreas", Experience = 12 },
                new Employee { Id = 9, Name = "Herbert", Experience = 14 }
            };
        }
    }
}

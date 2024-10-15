using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == searchId);
            if (employee != null)
            {
                Console.Write("Enter the percentege: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee emplo in list)
            {
                Console.WriteLine(emplo);
            }
        }
    }
}
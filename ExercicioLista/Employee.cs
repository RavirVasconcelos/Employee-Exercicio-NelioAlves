using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    public class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percent)
        {
            Salary += (Salary * percent / 100);
        }
        public override string ToString()
        {
            return Id +
                ", " + Name +
                ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
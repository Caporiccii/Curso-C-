using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POO.Ex_Aula_78
{
    public class Employers : IEmployersService
    {
        public Employers(int id, double salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }

        public Employers(){}

        public int Id { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString() => string.Format($"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

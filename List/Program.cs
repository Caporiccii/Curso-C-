using POO.Ex_Aula_78;
using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employers> listEmplyes = new List<Employers>();

            Console.WriteLine("How many employees will be registred?");
            var numberEmployes = int.Parse(Console.ReadLine());

            while (listEmplyes.Count < numberEmployes)
            {
                Console.WriteLine($"Employee #{ listEmplyes.Count + 1 } :");

                Console.Write("Id: ");
                var id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Salary: ");
                var salary = double.Parse(Console.ReadLine());

                listEmplyes.Add(new Employers(id, salary, name));
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            var searchId = int.Parse(Console.ReadLine());

            Employers valideId = listEmplyes.Find(e => e.Id == searchId);

            if (valideId != null)
            {
                Console.WriteLine("Enter the percentage: ");
                var percentage = double.Parse(Console.ReadLine());

                valideId.IncreaseSalary(percentage);
                

            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

                Console.WriteLine("Updated list of employees:");
                foreach (var obj in listEmplyes)
                {
                    Console.WriteLine(obj.ToString());
                }
            
        }
    } 
}

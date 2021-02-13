//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace POO.Ex_Aula_78
//{
//    public class EmployerService 
//    {
       

//        public void GetEmployerInformation()
//        {
//            Console.WriteLine("How many employees will be registred?");
//            var numberEmployes = int.Parse(Console.ReadLine());

//            while (listEmplyes.Count < numberEmployes)
//            {
//                Console.WriteLine($"Employee #{ listEmplyes.Count + 1 } :");

//                Console.Write("Id: ");
//                var id = int.Parse(Console.ReadLine());

//                Console.Write("Name: ");
//                var name = Console.ReadLine();

//                Console.Write("Salary: ");
//                var salary = double.Parse(Console.ReadLine());

//                listEmplyes.Add(new Employers(id, salary, name));
//            }

//            Console.WriteLine("Enter the employee id that will have salary increase: ");
//            var searchId = int.Parse(Console.ReadLine());

//            var valideId = listEmplyes.Find(e => e.Id == searchId);

//            if (valideId == null)
//            {
//                Console.WriteLine("This id does not exist!");
//                PrintUpdatedListEmployers();
//            }
//            else
//            {
//                Console.WriteLine("Enter the percentage: ");
//                var percentage = double.Parse(Console.ReadLine());

//                employers.IncreaseSalary(percentage);

//                Console.WriteLine("Updated list of employees:");
//                foreach (var obj in listEmplyes)
//                {
//                    Console.WriteLine(obj.ToString());
//                }

//                //PrintUpdatedListEmployers();
//            }
//        }

        


//        public void PrintUpdatedListEmployers()
//        {
            
//        }

//        public void Handle()
//        {
//            GetEmployerInformation();

//        }

//        //void IEmployersService.IncreaseSalary(double percentage)
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}

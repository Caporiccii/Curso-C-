using System;

namespace repeticao
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Password Please: ");
            string password = Console.ReadLine();

            while (!password.Equals("2002"))
            {
                Console.WriteLine("wrong Password ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Ok");

        }
    }
}

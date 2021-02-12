using POO.EX_Aula_60;
using POO.Metodos;
using System;
using System.Globalization;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountService accountService = new AccountService();
            Account account =  new Account();

            Console.WriteLine("Entre com o numero da conta");
            account.AccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta");
            account.AccountOwner = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
             account.FirstDepositExist = Console.ReadLine();

            if (account.FirstDepositExist.Equals("s"))
            {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                account.Total = account.FirstDeposit = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados da Conta: ");
                account.ToString();
            }
            else
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(account.ToString());

            Console.WriteLine("Entre com o valor do depósito: ");
            account.Total += account.Deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(account.ToString());

            Console.WriteLine("Entre com o valor de saque: ");
            account.WithdrawlValue = double.Parse(Console.ReadLine());
            account.Total = accountService.WithdrawlAccount(account.Total, account.WithdrawlValue, 5.00);
           
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(account.ToString());



            //double xA, xB, xC, yA, yB, yC;
            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com as medidas do triângulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            //Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}

            //CalculoTriangulo calculoTriangulo = new CalculoTriangulo();

            //calculoTriangulo.Handle();


        }
    }
}

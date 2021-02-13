using System;
using System.Collections.Generic;
using System.Text;

namespace POO.EX_Aula_60
{
    public interface IAccountService 
    {
        public double SumDeposit(double firstdeposit, double newdeposit);

        public double WithdrawlAccount(double total, double withdrawlvalue, double discount);

        public bool ValidateFirstDeposit(string firstdepositexist);
    }
}

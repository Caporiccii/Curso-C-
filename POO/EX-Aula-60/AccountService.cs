using System;
using System.Collections.Generic;
using System.Text;

namespace POO.EX_Aula_60
{
    public class AccountService : IAccountService
    {
        public double SumDeposit(double firstdeposit, double newdeposit) => firstdeposit + newdeposit;

        public double WithdrawlAccount(double total, double withdrawlvalue, double discount) => (total - withdrawlvalue) - discount;
    }
}

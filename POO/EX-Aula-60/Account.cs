using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POO.EX_Aula_60
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public double FirstDeposit { get; set; }
        public double Deposit { get; set; }
        public double Total { get; set; }
        public string FirstDepositExist { get; set; }
        public double WithdrawlValue { get; set; }

        public override string ToString() => string.Format($"Conta: {AccountNumber}, Titular: {AccountOwner}, Saldo: R$ {Total}", "F2", CultureInfo.InvariantCulture); 

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Services.Commands
{
    public class MakeDepositCommand
    {
        public MakeDepositCommand(string accountNumber, double amount)
        {
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            Amount = amount;
        }

        public string AccountNumber { get; set; }
        public double Amount { get; set; }
    }
}

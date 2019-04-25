using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Services.Commands
{
    public class TransferMoneyCommand
    {
        public TransferMoneyCommand(string sourceAccountNumber, string destinationAccountNumber, double amount)
        {
            SourceAccountNumber = sourceAccountNumber ?? throw new ArgumentNullException(nameof(sourceAccountNumber));
            DestinationAccountNumber = destinationAccountNumber ?? throw new ArgumentNullException(nameof(destinationAccountNumber));
            Amount = amount;
        }

        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public double Amount { get; set; }
    }
}

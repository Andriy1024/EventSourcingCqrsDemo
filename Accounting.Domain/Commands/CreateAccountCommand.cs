using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Services.Commands
{
    public class CreateAccountCommand
    {
        public CreateAccountCommand(string accountNumber, string owner)
        {
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }

        public string AccountNumber { get; set; }
        public string Owner { get; set; }
    }
}

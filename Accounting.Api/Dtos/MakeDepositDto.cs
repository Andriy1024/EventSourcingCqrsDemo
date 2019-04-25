using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Api.Dtos
{
    public class MakeDepositDto
    {
        public string AccountNumber { get; set; }
        public double Amount { get; set; }
    }
}

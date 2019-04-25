using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Api.Dtos
{
    public class CreateAccountDto
    {
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
    }
}

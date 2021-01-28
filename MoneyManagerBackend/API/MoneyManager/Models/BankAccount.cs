using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManager.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}

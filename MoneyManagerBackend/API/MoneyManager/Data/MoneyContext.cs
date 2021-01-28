using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoneyManager.Models;

namespace MoneyManager.Data
{
    public class MoneyContext : DbContext
    {
        public MoneyContext (DbContextOptions<MoneyContext> options)
            : base(options)
        {
        }

        public DbSet<MoneyManager.Models.BankAccount> BankAccount { get; set; }
    }
}

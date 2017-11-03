using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Models;

namespace Wallet.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AccountType> AccountTypes { get; set; }
    }
}

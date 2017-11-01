using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Account
    {
        [Key]
        public long Id { get; set; }
        public string Description { get; set; }
        public int AccountTypeId { get; set; }

        public AccountType AccountType { get; set; }
    }

    public class AccountType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

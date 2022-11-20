using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ozbek.Bank.Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Repository.Seeds
{
    internal class AccountTypeSeed : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> builder)
        {


            builder.HasData(
                new AccountType { AccounTypeId = 1, Name = "TL", CreatedDate = DateTime.Now },
                new AccountType { AccounTypeId = 2, Name = "EUR", CreatedDate = DateTime.Now },
                new AccountType { AccounTypeId = 3, Name = "USD", CreatedDate = DateTime.Now });

        }
    }
}

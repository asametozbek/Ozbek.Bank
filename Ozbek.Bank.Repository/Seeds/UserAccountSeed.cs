using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ozbek.Bank.Core.Models.Entity;

namespace Ozbek.Bank.Repository.Seeds
{
    internal class UserAccountSeed : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {


            builder.HasData(
                new UserAccount { UserAccountId = 1, UserId = 1, AccountTypeId = 1, Balance = 1500, CreatedDate = DateTime.Now },
                new UserAccount { UserAccountId = 2, UserId = 1, AccountTypeId = 2, Balance = 100, CreatedDate = DateTime.Now });

        }
    }
}

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
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {


            builder.HasData(
                new User { UserId = 1, FirstName = "Abdussamet", LastName = "Özbek", IdentityNumber = "01234567890", Pin = "1234", CreatedDate = DateTime.Now });

        }
    }
}

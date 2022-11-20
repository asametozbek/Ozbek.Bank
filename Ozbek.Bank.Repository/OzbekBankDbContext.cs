using Microsoft.EntityFrameworkCore;
using Ozbek.Bank.Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Repository
{
    public class OzbekBankDbContext : DbContext
    {
        //const string connectionString = "Server=DESKTOP-A2VCHQ2\\SQLEXPRESS;Database=OzbekBank;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";

        //public OzbekBankDbContext() : base() { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer(connectionString);

        //}
        public OzbekBankDbContext(DbContextOptions<OzbekBankDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public override int SaveChanges()
        {


            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;

                                entityReference.UpdatedDate = DateTime.Now;
                                break;
                            }

                    }
                }


            }


            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

       
    }
}

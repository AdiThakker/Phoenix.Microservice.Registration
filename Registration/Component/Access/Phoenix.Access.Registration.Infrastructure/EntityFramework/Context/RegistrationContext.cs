using Microsoft.EntityFrameworkCore;
using Phoenix.Access.Registration.Core.Entities;

namespace Phoenix.Access.Registration.Infrastructure.EntityFramework.Context
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext()
               : base()
        {
        }

        public RegistrationContext(DbContextOptions<RegistrationContext> options)
                : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}

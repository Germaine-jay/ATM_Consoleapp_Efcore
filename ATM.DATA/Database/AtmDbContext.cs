using ATM.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace ATM.DATA.Database
{
    public class AtmDbContext:DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options)
          : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(e =>
            {
                e.Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                e.Property(p => p.LastName)
                   .IsRequired(false)
                   .HasMaxLength(30);

                e.HasIndex(p => new { p.Email, p.PhoneNumber }, $"IX_Unique_{nameof(Customer.Email)}{nameof(Customer.PhoneNumber)}")
                   .IsUnique();

                e.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12);

            });

            modelBuilder.Entity<Account>()
                .HasKey(a => a.AccountNumber);

            modelBuilder.Entity<Account>(p =>
            {
                p.Property(p => p.AccountNumber)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn(2076225212, 15);

                p.Property(p => p.AccountBalance)
                    .HasDefaultValue(0);

                p.Property(p => p.Accountpin)
                    .HasDefaultValue("0000");
            });

            modelBuilder.Entity<Transaction>(p =>
            {
                p.Property(p => p.TransactionDate)
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Customer>()
                .HasOne(t1 => t1.Account)
                .WithOne(t2 => t2.Customer)
                .HasForeignKey<Account>(t2 => t2.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }

        public static implicit operator string(AtmDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}

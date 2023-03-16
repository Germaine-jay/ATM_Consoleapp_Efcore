using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace ATM.DATA.Database
{
    public class AtmDbContextFactory : IDesignTimeDbContextFactory<AtmDbContext>
    {

        public AtmDbContextFactory()
        {

        }

        public AtmDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<AtmDbContext>();
            var ConnectionString = @"Data Source=GERMANE-PC\SQLEXPRESS;Initial Catalog=EFcoreAtmDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            OptionBuilder.UseSqlServer(ConnectionString);
            return new AtmDbContext(OptionBuilder.Options);
        }
    }
}

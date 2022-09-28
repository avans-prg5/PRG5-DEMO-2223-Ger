using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp_2022_09_28.Models
{
    public class ContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
    {

        public ContextFactory()
        {
        }

        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("./appsettings.json")
          .Build();


        public PhoneBookContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("PhoneBook"));
            return new PhoneBookContext(builder.Options);
        }
    }
}

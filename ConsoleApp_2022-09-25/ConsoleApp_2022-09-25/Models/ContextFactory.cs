using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConsoleApp_2022_09_25.Models
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

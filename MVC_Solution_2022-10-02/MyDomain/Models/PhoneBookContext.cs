using Microsoft.EntityFrameworkCore;

namespace MyDomain.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext()
        {
        }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Hobby> Hobbies { get; set; } = null!;
    }
}


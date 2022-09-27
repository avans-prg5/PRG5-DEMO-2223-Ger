using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2022_09_25.Models
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

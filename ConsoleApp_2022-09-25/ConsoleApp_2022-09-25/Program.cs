using ConsoleApp_2022_09_25.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace ConsoleApp_2022_09_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- program start ---");

            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                Console.WriteLine( "=== table content ===");
                context.Persons.ToList().ForEach(p =>
                {
                    Console.WriteLine(p.FullName);
                });

                Console.WriteLine("= deleting all rows from DBtable Persons");
                context.Persons.RemoveRange(context.Persons);
                context.SaveChanges();

                Console.WriteLine("=== table content ===");
                if (context.Persons.Count() > 0)
                {
                    context.Persons.ToList().ForEach(p =>
                    {
                        Console.WriteLine(p.FullName);
                    });
                }
                else
                {
                    Console.WriteLine("empty");
                }

                Console.WriteLine("= adding local list of persons to DBtable");
                context.Persons.AddRange(new LocalBook().Persons);
                context.SaveChanges();

                Console.WriteLine("=== content ===");
                context.Persons.ToList().ForEach(p =>
                {
                    Console.WriteLine(p.FullName);

                    if (p.Hobbies != null)
                    {
                        p.Hobbies.ToList().ForEach(h =>
                        {
                            Console.WriteLine("  h:" + h.Title);
                        });
                    }
                });

            }
            Console.WriteLine("--- program end ---");
        }
    }
}
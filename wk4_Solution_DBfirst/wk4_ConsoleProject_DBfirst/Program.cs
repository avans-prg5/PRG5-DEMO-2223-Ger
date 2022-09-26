using wk4_ConsoleProject_DBfirst.Models;

namespace wk4_ConsoleProject_DBfirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- program start ---");
            using (var context = new PhoneBookContext())
            {
                context.Persons.ToList().ForEach(p =>
                {
                    Console.WriteLine(p.FirstName + " " + p.LastName + " (age)");
                });
            }
            Console.WriteLine("--- program end ---");
        }
    }
}
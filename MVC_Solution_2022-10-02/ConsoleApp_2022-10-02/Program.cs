using MyDomain.Models;

namespace ConsoleApp_2022_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- program start ----");

            //{
            //    new LocalBook().Persons.ForEach(p =>
            //    {
            //        Console.WriteLine(p.FullName);
            //    });

            //}




            //    using (var context = new ContextFactory().CreateDbContext(new string[0]))
            //    {

            //        Console.WriteLine("= deleting all existing rows from DB PhoneBook =");
            //        context.Persons.RemoveRange(context.Persons);
            //        context.Hobbies.RemoveRange(context.Hobbies);
            //        context.SaveChanges();

            //        Console.WriteLine("= writing LocalBook content to PhoneBook =");
            //        context.Persons.AddRange(new LocalBook().Persons);
            //        context.SaveChanges();

            //        Console.WriteLine("=== content ===");
            //        context.Persons.ToList().ForEach(p =>
            //        {
            //            Console.WriteLine(p.FullName);

            //            if (p.Hobbies != null)
            //            {
            //                p.Hobbies.ToList().ForEach(h =>
            //                {
            //                    Console.WriteLine("  :" + h.Titel);
            //                });
            //            }
            //            else { Console.WriteLine("  : <none>"); }
            //        });


            //    }

            Console.WriteLine("--- program end ----");
        }
    }
}
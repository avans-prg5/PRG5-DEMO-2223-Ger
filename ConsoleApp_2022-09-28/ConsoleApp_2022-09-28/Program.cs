using ConsoleApp_2022_09_28.Models;

namespace ConsoleApp_2022_09_28
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


            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {

                context.Persons.AddRange(new LocalBook().Persons);

                context.SaveChanges();


            }




            Console.WriteLine("--- program end ----");
        }
    }
}
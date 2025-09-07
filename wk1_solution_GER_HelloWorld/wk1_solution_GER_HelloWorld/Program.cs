using MyDomain;

namespace wk1_solution_GER_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            //Console.WriteLine("Enter your name: ");
            //String? input;
            //input = Console.ReadLine();
            //Console.WriteLine("hello " + input);

            //part 2
            Person p = new Person();
            //Console.Write("Enter your  first name: ");
            //p.Firstname = Console.ReadLine();
            //Console.Write("Enter your middle name: ");
            //p.MiddleName = Console.ReadLine();
            //Console.Write("Enter your   last name: ");
            //p.LastName = Console.ReadLine();

            bool correct = false;
            DateTime bday = new DateTime(2000, 1, 1);

            while (!correct)
            {
                Console.Write("Enter your date of birth (yyyy,m,d) : ");
                string? instr = Console.ReadLine();
                if (instr != null)
                {
                    try
                    {
                        bday = DateTime.Parse(instr);
                        correct = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("wrong format, try again ");
                        //try again
                    }
                }
            }
            p.Birthdate = bday;

            Console.WriteLine("this is your age: " + p.Age);
            //Console.WriteLine("hello " + p.FullName);
        }
    }
}
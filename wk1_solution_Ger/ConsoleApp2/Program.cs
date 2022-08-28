using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! program 2");

        //String? input;
        //input = Console.ReadLine();
        //Console.WriteLine("you said: " + input);
        //Console.Write("Press <Q> to quit... ");
        //while (Console.ReadKey().Key != ConsoleKey.Q)
        //{
        //    Console.WriteLine("\r");
        //    Console.Write("Press <Q> to quit... ");
        //}

        //Console.WriteLine("bye");
        String? input = "niks";
        while (input != "quit")
        {
            //try
            //{
                Console.WriteLine("type quit to end program");
                input = Console.ReadLine();
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine("exception");
            //}

        }
    }
}
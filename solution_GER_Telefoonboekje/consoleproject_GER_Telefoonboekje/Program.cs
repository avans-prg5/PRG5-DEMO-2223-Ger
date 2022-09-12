namespace wk1_solution_GER_Telefoonboekje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //book.PrintSortedByLastName();
            //book.PrintAllPersonsWithFirstNameAs("Mister");
            book.PrintSortedByAge();
        }
    }
}
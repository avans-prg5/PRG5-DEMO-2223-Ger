using MyDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace wk1_solution_GER_Telefoonboekje
{
    internal class Book
    {

        //adding elements using collection-initializer syntax

        List<Person> persons = new List<Person>()
        {
          new Person() { Firstname = "John",   LastName = "Drummajor",Birthdate = new DateTime(1943,03,29)},
          new Person() { Firstname = "Blaise", LastName = "Pascal",   Birthdate = new DateTime(1623,06,19)},
          new Person() { Firstname = "Peter",  LastName = "Gabriel",  Birthdate = new DateTime(1950,02,13)},
          new Person() { Firstname = "Mister", LastName = "Ed",       Birthdate = new DateTime(1949,01,01)},
          new Person() { Firstname = "Mister", LastName = "Zorro",    Birthdate = new DateTime(1957,10,01)},
        };

        public void PrintSortedByLastName()
        {


            IEnumerable<Person> mygroup1 = persons
                .OrderByDescending(person => person.LastName);

            IEnumerable<Person> mygroup2 = from p in persons orderby p.LastName descending select p;


            foreach (var item in mygroup2)
            {
                Console.WriteLine(item.LastName);
            }
        }

    }
}

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
    public class Book
    {

        //adding elements using collection-initializer syntax

        private List<Person> persons = new List<Person>()
        {
          new Person() { Firstname = "John",   LastName = "Drummajor",Birthdate = new DateTime(1943,03,29)},
          new Person() { Firstname = "Blaise", LastName = "Pascal",   Birthdate = new DateTime(1623,06,19)},
          new Person() { Firstname = "Peter",  LastName = "Gabriel",  Birthdate = new DateTime(1950,02,13)},
          new Person() { Firstname = "Mister", LastName = "Eduarte",  Birthdate = new DateTime(1949,01,01)},
          new Person() { Firstname = "Mister", LastName = "Zorro",    Birthdate = new DateTime(1957,10,01)},
        };

        public void PrintSortedByLastName()
        {
            foreach (var p in persons)
            {
                Console.WriteLine(p.FullName);
            }



            //IEnumerable<Person> mygroup1 = persons
            //    .OrderByDescending(person => person.LastName);

            //IEnumerable<Person> mygroup2 = from p in persons orderby p.LastName descending select p;


            //foreach (var item in mygroup2)
            //{
            //    Console.WriteLine(item.LastName);
            //}
        }

        public void PrintAllPersons(string fname)
        {
            IEnumerable<Person> result =  from p in persons where p.Firstname==fname select p;
            foreach (var p in result)
            {
                Console.WriteLine(p.FullName);
            }

        }

    }
}

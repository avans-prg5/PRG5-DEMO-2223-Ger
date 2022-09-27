using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2022_09_25.Models
{
    public class LocalBook
    {
        private List<Person> persons = new List<Person>()
        {
          new Person() { FirstName = "John",   LastName = "Drummajor",Birthdate = new DateTime(1943,03,29)},
          new Person() { FirstName = "Blaise", LastName = "Pascal",   Birthdate = new DateTime(1623,06,19)},
          new Person() { FirstName = "Peter",  LastName = "Gabriel",  Birthdate = new DateTime(1950,02,13)},
          new Person() { FirstName = "Mister", LastName = "Eduarte",  Birthdate = new DateTime(1949,01,01)},
          new Person() { FirstName = "Mister", LastName = "Zorro",    Birthdate = new DateTime(1957,10,01)},
          new Person() { FirstName = "Paul",   LastName = "McCartney",Birthdate = new DateTime(1942,06,18)},
          new Person() { FirstName = "Ad",     LastName = "Baantjer" ,Birthdate = new DateTime(1923,09,16)},
          new Person() { FirstName = "Bea",    LastName = "Knol",     Birthdate = new DateTime(1989,09,12)},
          new Person() { FirstName = "Celine", LastName = "Stakkeren",Birthdate = new DateTime(1989,09,12),
              Hobbies = new List<Hobby>()
              {
                  new Hobby(){Title="Zwemmen"},
                  new Hobby(){Title="Dansen"}
              }
          }
        };

        public List<Person> Persons
        {
            get { return persons; }
        }


        public void PrintSortedByLastName()
        {
            IEnumerable<Person> mygroup = persons
                .OrderByDescending(person => person.LastName);

            foreach (var p in mygroup)
            {
                Console.WriteLine(p.LastName);
            }
        }

        public void PrintAllPersonsWithFirstNameAs(string fname)
        {
            IEnumerable<Person> result = from p in persons where p.FirstName == fname select p;
            foreach (var p in result)
            {
                Console.WriteLine(p.FullName);
            }

        }

        public void PrintSortedByAge()
        {
            IEnumerable<Person> result = persons
                .OrderBy(p => p.Age);

            foreach (var p in result)
            {
                Console.WriteLine(p.Age.ToString() + p.FullName);
            }
        }
    }
}

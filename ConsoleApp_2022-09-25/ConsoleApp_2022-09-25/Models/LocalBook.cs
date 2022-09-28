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
        //private readonly List<Person> _persons = new List<Person>();

        //public List<Person> Persons
        //{
        //    get
        //    {
        //        if (!_persons.Any())
        //        {
        //            var hobby1 = new Hobby { Title = "Zwemmen" };
        //            var hobby2 = new Hobby { Title = "Dansen" };
        //            var hobby3 = new Hobby { Title = "Zingen" };
        //            var hobby4 = new Hobby { Title = "Wiskunde" };
        //            var hobby5 = new Hobby { Title = "Paardrijden" };

        //            _persons.Add(new Person()
        //            {
        //                FirstName = "John",
        //                LastName = "Drummajor",
        //                Birthdate = new DateTime(1943, 03, 29)
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Blaise",
        //                LastName = "Pascal",
        //                Birthdate = new DateTime(1623, 06, 19),
        //                Hobbies = new List<Hobby> { hobby4 }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Peter",
        //                LastName = "Gabriel",
        //                Birthdate = new DateTime(1950, 02, 13),
        //                Hobbies = new List<Hobby> { hobby3 }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Mister",
        //                LastName = "Eduarte",
        //                Birthdate = new DateTime(1949, 01, 01),
        //                Hobbies = new List<Hobby> { hobby4 }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Mister",
        //                LastName = "Zorro",
        //                Birthdate = new DateTime(1957, 10, 01),
        //                Hobbies = new List<Hobby> { hobby5 }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Paul",
        //                LastName = "McCartney",
        //                Birthdate = new DateTime(1942, 06, 18),
        //                Hobbies = new List<Hobby> { hobby3 }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Ad",
        //                LastName = "Baantjer",
        //                Birthdate = new DateTime(1923, 09, 16)
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Bea",
        //                LastName = "Knol",
        //                Birthdate = new DateTime(1989, 09, 12),
        //                Hobbies = new List<Hobby>() { new Hobby() { Title = "Zwemmen" }, new Hobby() { Title = "Dansen" } }
        //            });
        //            _persons.Add(new Person()
        //            {
        //                FirstName = "Celine",
        //                LastName = "Stakkeren",
        //                Birthdate = new DateTime(1989, 09, 12),
        //                Hobbies = new List<Hobby>() { new Hobby() { Title = "Zwemmen" }, new Hobby() { Title = "Dansen" } }
        //            });
        //        }
        //        return _persons;
        //    }
        //}

        public List<Person> Persons = new List<Person>()
        {
          new Person() { FirstName = "John",   LastName = "Drummajor",Birthdate = new DateTime(1943, 03, 29)},
          new Person() { FirstName = "Blaise", LastName = "Pascal",   Birthdate = new DateTime(1623, 06, 19)},
          new Person() { FirstName = "Peter",  LastName = "Gabriel",  Birthdate = new DateTime(1950, 02, 13)},
          new Person() { FirstName = "Mister", LastName = "Eduarte",  Birthdate = new DateTime(1949, 01, 01)},
          new Person() { FirstName = "Mister", LastName = "Zorro",    Birthdate = new DateTime(1957, 10, 01)},
          new Person() { FirstName = "Paul",   LastName = "McCartney",Birthdate = new DateTime(1942, 06, 18)},
          new Person() { FirstName = "Ad",     LastName = "Baantjer" ,Birthdate = new DateTime(1923, 09, 16)},
          new Person() { FirstName = "Bea",    LastName = "Knol",     Birthdate = new DateTime(1989, 09, 12)},
          new Person() { FirstName = "Celine", LastName = "Stakkeren",Birthdate = new DateTime(1989, 09, 12),
              Hobbies = new List<Hobby>() { new Hobby(){Title="Zwemmen"}, new Hobby(){Title="Dansen"} }     }
        };


        public void PrintSortedByLastName()
        {
            IEnumerable<Person> mygroup = Persons
                .OrderByDescending(person => person.LastName);

            foreach (var p in mygroup)
            {
                Console.WriteLine(p.LastName);
            }
        }

        public void PrintAllPersonsWithFirstNameAs(string fname)
        {
            IEnumerable<Person> result = from p in Persons where p.FirstName == fname select p;
            foreach (var p in result)
            {
                Console.WriteLine(p.FullName);
            }

        }

        public void PrintSortedByAge()
        {
            IEnumerable<Person> result = Persons
                .OrderBy(p => p.Age);

            foreach (var p in result)
            {
                Console.WriteLine(p.Age.ToString() + p.FullName);
            }
        }
    }
}

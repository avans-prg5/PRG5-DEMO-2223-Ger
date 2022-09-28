namespace ConsoleApp_2022_09_28.Models
{
    public class LocalBook
    {
        private readonly List<Person> _persons = new List<Person>();
        public List<Person> Persons
        {
            get
            {
                if (!_persons.Any())
                {
                    var hobby1 = new Hobby { Titel = "Zwemmen" };
                    var hobby2 = new Hobby { Titel = "Dansen" };

                    _persons.Add(new Person()
                    {



                        FirstName = "Bea",
                        LastName = "Knol",
                        Birthdate = new DateTime(1989, 09, 12),
                        Hobbies = new List<Hobby>() { hobby1, hobby2 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Celine",
                        LastName = "Stakkeren",
                        Birthdate = new DateTime(1989, 09, 12),
                        Hobbies = new List<Hobby>() { hobby1, hobby2 }

                    });

                }
                return _persons;
            }

        }
    }
}
//public List<Person> Persons = new List<Person>()
//{
//  new Person() { FirstName = "John",   LastName = "Drummajor",Birthdate = new DateTime(1943, 03, 29)},
//  new Person() { FirstName = "Blaise", LastName = "Pascal",   Birthdate = new DateTime(1623, 06, 19)},
//  new Person() { FirstName = "Peter",  LastName = "Gabriel",  Birthdate = new DateTime(1950, 02, 13)},
//  new Person() { FirstName = "Mister", LastName = "Eduarte",  Birthdate = new DateTime(1949, 01, 01)},
//  new Person() { FirstName = "Mister", LastName = "Zorro",    Birthdate = new DateTime(1957, 10, 01)},
//  new Person() { FirstName = "Paul",   LastName = "McCartney",Birthdate = new DateTime(1942, 06, 18)},
//  new Person() { FirstName = "Ad",     LastName = "Baantjer" ,Birthdate = new DateTime(1923, 09, 16)},
//  new Person() { FirstName = "Bea",    LastName = "Knol",     Birthdate = new DateTime(1989, 09, 12),
//      Hobbies = new List<Hobby>() { new Hobby(){Titel="Zwemmen"}, new Hobby(){Titel="Dansen"} } },     
//    new Person() { FirstName = "Celine", LastName = "Stakkeren",Birthdate = new DateTime(1989, 09, 12),
//      Hobbies = new List<Hobby>() { new Hobby(){Titel="Zwemmen"}, new Hobby(){Titel="Dansen"} }     }
//};
//    }
//}

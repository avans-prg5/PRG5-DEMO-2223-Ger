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
                    var hobby3 = new Hobby { Titel = "Zingen" };
                    var hobby4 = new Hobby { Titel = "Wiskunde" };
                    var hobby5 = new Hobby { Titel = "Paardrijden" };

                    _persons.Add(new Person()
                    {
                        FirstName = "John",
                        LastName = "Drummajor",
                        Birthdate = new DateTime(1943, 03, 29)
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Blaise",
                        LastName = "Pascal",
                        Birthdate = new DateTime(1623, 06, 19),
                        Hobbies = new List<Hobby> { hobby4 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Peter",
                        LastName = "Gabriel",
                        Birthdate = new DateTime(1950, 02, 13),
                        Hobbies = new List<Hobby> { hobby3 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Mister",
                        LastName = "Eduarte",
                        Birthdate = new DateTime(1949, 01, 01),
                        Hobbies = new List<Hobby> { hobby4 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Mister",
                        LastName = "Zorro",
                        Birthdate = new DateTime(1957, 10, 01),
                        Hobbies = new List<Hobby> { hobby5 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Paul",
                        LastName = "McCartney",
                        Birthdate = new DateTime(1942, 06, 18),
                        Hobbies = new List<Hobby> { hobby3 }
                    });
                    _persons.Add(new Person()
                    {
                        FirstName = "Ad",
                        LastName = "Baantjer",
                        Birthdate = new DateTime(1923, 09, 16)
                    });
   
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

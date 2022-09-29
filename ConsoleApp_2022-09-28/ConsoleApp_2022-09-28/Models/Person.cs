namespace ConsoleApp_2022_09_28.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Hobby> Hobbies { get; set; } = null!;

        public string FullName => FirstName + " " + LastName;

    }
}

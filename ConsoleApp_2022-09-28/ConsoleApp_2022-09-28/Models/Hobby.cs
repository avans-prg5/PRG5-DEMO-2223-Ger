using System.ComponentModel.DataAnnotations;

namespace ConsoleApp_2022_09_28.Models
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Titel { get; set; }

        public virtual ICollection<Person> Participants { get; set; } = null!;

    }
}

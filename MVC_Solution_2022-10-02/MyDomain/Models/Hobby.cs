using System.ComponentModel.DataAnnotations;

namespace MyDomain.Models
{
    public class Hobby
    {
 
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string? Titel { get; set; }

        public byte[]? HobbyImage { get; set; }

        public virtual ICollection<Person> Participants { get; set; } = null!;

    }
}

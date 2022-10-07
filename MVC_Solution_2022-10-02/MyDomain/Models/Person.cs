using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyDomain.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Moet ingevuld worden van Ger")]
        [StringLength(25)]
        [MinLength(3, ErrorMessage = "Moet min 3 lang zijn")]
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Hobby> Hobbies { get; set; } = null!;

        public string FullName => FirstName + " " + LastName;

    }
}

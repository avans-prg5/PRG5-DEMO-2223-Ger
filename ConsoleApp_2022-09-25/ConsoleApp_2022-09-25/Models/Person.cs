using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2022_09_25.Models
{

    public class Person
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public virtual ICollection<Hobby> Hobbies { get; set; } = null!;

        public string FullName => FirstName + " " + LastName;

        public int Age
        {
            get
            {
                int a = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month == Birthdate.Month)
                {
                    if (DateTime.Now.Day < Birthdate.Day)
                    {
                        a--;
                    }
                }
                else if (DateTime.Now.Day < Birthdate.Day)
                {
                    a--;
                }
                return a;
            }
        }
    }
}


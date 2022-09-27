using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2022_09_25.Models
{
    public class Hobby
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public String Title { get; set; }

        public Hobby(string title)
        {
            Title = title;
        }

        public Hobby()
        {
            Title = "unknown";
        }
    }
}

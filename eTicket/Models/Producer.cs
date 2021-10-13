using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string ProducerName { get; set; }

        [Display(Name = "Biography")]
        public string ProducerBio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

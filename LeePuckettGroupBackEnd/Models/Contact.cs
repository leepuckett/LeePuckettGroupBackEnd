using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeePuckettGroupBackEnd.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace LeePuckettGroupBackEnd.Models
{
   
    public class Contact
    {
        [Key]
        public int Contact_Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name may not be longer than 50 charaters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name may not be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
   
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter valid email")]
        [DataType(DataType.EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public status Status { get; set; }
    }

    public enum status {
        Active, Inactive
    }

}

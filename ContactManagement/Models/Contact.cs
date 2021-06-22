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
        public int id { get; set; }

        [StringLength(150)]
        public string firstName { get; set; }

        [StringLength(100)]
        public string lastName { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        [StringLength(15)]
        public string phoneNumber { get; set; }

        public status status { get; set; }
    }

    public enum status {
        Active, Inactive
    }

}

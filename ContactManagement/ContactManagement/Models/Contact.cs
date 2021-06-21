using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Models
{
    public class Contact
    {
        public long? id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public status status { get; set; }
    }

    public enum status {
        Active, Inactive
    }

}

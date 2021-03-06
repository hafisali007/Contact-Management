using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Models
{
    public class ContactAppContext:DbContext
    {
        public ContactAppContext(DbContextOptions options)
              : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }
    }

   }

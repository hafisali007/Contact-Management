using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;

namespace ContactManagement.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            List<Contact> list = new List<Contact>();
            IEnumerable<Contact> contacts = list;
         
            return View(contacts);
           
        }
    }
}

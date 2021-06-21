using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;

namespace ContactManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
      
            private readonly ContactAppContext _context;

            // initiate database context
            public ContactController(ContactAppContext context)
            {
                _context = context;
            }

            [HttpGet]
            [Route("getAllContact")]
            public IEnumerable<Contact> GetAll()
            {
                // fetch all contact records 
                return _context.Contact.ToList();
            }

            [HttpGet("{id}")]
            [Route("getContact")]
            public IActionResult GetById(long id)
            {
                // filter contact records by contact id
                var item = _context.Contact.FirstOrDefault(t => t.id == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            [HttpPost]
            [Route("addContact")]
            public IActionResult Create([FromBody] Contact item)
            {
                // set bad request if contact data is not provided in body
                if (item == null)
                {
                    return BadRequest();
                }
                _context.Contact.Add(new Contact
                {
                    firstName = item.firstName,
                    lastName = item.lastName,
                    email = item.email,
                    phoneNumber = item.phoneNumber,
                    status = item.status
                });
                _context.SaveChanges();

                return Ok(new { message = "Contact is added successfully." });
            }

            [HttpPut("{id}")]
            [Route("updateContact")]
            public IActionResult Update(long id, [FromBody] Contact item)
            {
                // set bad request if contact data is not provided in body
                if (item == null || id == 0)
                {
                    return BadRequest();
                }

                var contact = _context.Contact.FirstOrDefault(t => t.id == id);
                if (contact == null)
                {
                    return NotFound();
                }

                contact.firstName = item.firstName;
                contact.lastName = item.lastName;
            contact.email = item.email;
                contact.phoneNumber = item.phoneNumber;
                contact.status = item.status;

                _context.Contact.Update(contact);
                _context.SaveChanges();
                return Ok(new { message = "Contact is updated successfully." });
            }


            [HttpDelete("{id}")]
            [Route("deleteContact")]
            public IActionResult Delete(long id)
            {
                var contact = _context.Contact.FirstOrDefault(t => t.id == id);
                if (contact == null)
                {
                    return NotFound();
                }

                _context.Contact.Remove(contact);
                _context.SaveChanges();
                return Ok(new { message = "Contact is deleted successfully." });
            }

        [HttpDelete("{id}")]
        [Route("statusContact")]
        public IActionResult Status(long id, [FromBody] Contact item)
        {
            var contact = _context.Contact.FirstOrDefault(t => t.id == id);
            if (contact == null)
            {
                return NotFound();
            }
            if(item.status == status.Active)
            {
                contact.status = status.Inactive;
            }
            else
            {
                contact.status = status.Active;
            }
            _context.Contact.Update(contact);
            _context.SaveChanges();
            return Ok(new { message = "Contact Status changed successfully." });
        }

    }
}

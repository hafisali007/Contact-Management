using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;

namespace ContactManagement.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {

        private readonly ContactAppContext _context;

        // initiate database context
        public ContactApiController(ContactAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getAllContact")]
        public IEnumerable<Contact> GetAll()
        {
            // fetch all contact records 
            return _context.Contacts.ToList();
        }

        [HttpGet("{id}")]
        [Route("getContact/{id}")]
        public IActionResult GetById(int id)
        {
            // filter contact records by contact id
            var item = _context.Contacts.FirstOrDefault(t => t.Id == id);
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
            _context.Contacts.Add(new Contact
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                PhoneNumber = item.PhoneNumber,
                Status = item.Status
            });
            _context.SaveChanges();

            return Ok(new { message = "Contact is added successfully." });
        }

        [HttpPut("{id}")]
        [Route("updateContact/{id}")]
        public IActionResult Update(int id, [FromBody] Contact item)
        {
            // set bad request if contact data is not provided in body
            if (item == null || id == 0)
            {
                return BadRequest();
            }

            var contact = _context.Contacts.FirstOrDefault(t => t.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.FirstName = item.FirstName;
            contact.LastName = item.LastName;
            contact.Email = item.Email;
            contact.PhoneNumber = item.PhoneNumber;
            contact.Status = item.Status;

            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok(new { message = "Contact is updated successfully." });
        }


        [HttpDelete("{id}")]
        [Route("deleteContact")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(t => t.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return Ok(new { message = "Contact is deleted successfully." });
        }


        [HttpDelete("{id}")]
        [Route("statusContact")]
        public IActionResult Status(int id, [FromBody] Contact item)
        {
            var contact = _context.Contacts.FirstOrDefault(t => t.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            if (item.Status == status.Active)
            {
                contact.Status = status.Inactive;
            }
            else
            {
                contact.Status = status.Active;
            }
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok(new { message = "Contact Status changed successfully." });
        }

    }
}

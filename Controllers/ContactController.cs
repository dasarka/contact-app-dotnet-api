using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ContactApp.Controllers.Resources;
using ContactApp.Models;
using ContactApp.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Controllers
{
    // set route attribute to make request as 'api/contact'
    [Route("api/contact")]
    public class ContactController : Controller
    {
        private readonly ContactDbContext context;
        private readonly IMapper mapper;

        // Initialize DB Context
        public ContactController(ContactDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<ContactResource>> GetAllContact()
        {
            // fetch all contact recods
            var contacts = await context.Contacts.ToListAsync();

            return mapper.Map<List<Contact>, List<ContactResource>>(contacts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchContactById(long id)
        {
            // filter contact records by contact id
            var contact = await context.Contacts.SingleOrDefaultAsync(c => c.Id == id);

            if (contact == null)
                return NotFound();

            var contactResource = mapper.Map<Contact, ContactResource>(contact);

            return Ok(contactResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreateNewContact([FromBody] ContactResource item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var contact = mapper.Map<ContactResource, Contact>(item);
            //contact.LastUpdate = DateTime.Now;
            context.Contacts.Add(contact);
            await context.SaveChangesAsync();

            var result = mapper.Map<Contact, ContactResource>(contact);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContactById(long id, [FromBody] ContactResource item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var contact = await context.Contacts.SingleOrDefaultAsync(c => c.Id == id);
            if (contact == null)
                return NotFound();

            mapper.Map<ContactResource, Contact>(item, contact);
            // contact.LastUpdate = DateTime.Now;
            await context.SaveChangesAsync();

            var result = mapper.Map<Contact, ContactResource>(contact);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactById(long id)
        {
            var contact = await context.Contacts.FindAsync(id);

            if (contact == null)
                return NotFound();

            context.Remove(contact);
            await context.SaveChangesAsync();

            return Ok(id);
        }
    }
}
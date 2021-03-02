using ContactApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Persistance
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }

    }
}
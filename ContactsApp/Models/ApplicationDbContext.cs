//namespace ContactsApp.Models
//{
//    public class ApplicationDbContext
//    {
//    }
//}
using Microsoft.EntityFrameworkCore;

namespace ContactsApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

}
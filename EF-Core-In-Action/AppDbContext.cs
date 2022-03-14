using EF_Core_In_Action.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_In_Action
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}

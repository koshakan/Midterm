using Microsoft.EntityFrameworkCore;
using Midterm.Models;

namespace Midterm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Math1> Maths { get; set; }

        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {

        }
    }
}

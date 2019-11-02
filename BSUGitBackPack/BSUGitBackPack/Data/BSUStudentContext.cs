using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class BSUStudentContext : DbContext
    {
        public BSUStudentContext(DbContextOptions<BSUStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}

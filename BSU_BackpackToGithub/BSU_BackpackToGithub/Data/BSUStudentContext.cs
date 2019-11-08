using Microsoft.EntityFrameworkCore;
using BSU_BackPackToGithub.Models;

namespace BSU_BackpackToGithub.Data
{
    public class BSUStudentContext : DbContext
    {
        public BSUStudentContext(DbContextOptions<BSUStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
    }
}

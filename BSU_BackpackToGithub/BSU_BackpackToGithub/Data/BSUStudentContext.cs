using Microsoft.EntityFrameworkCore;
using BSU_BackPackToGithub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BSU_BackpackToGithub.Data
{
    public class BSUStudentContext : IdentityDbContext
    {
        public BSUStudentContext(DbContextOptions<BSUStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Class> Class_New { get; set; }
    }
}

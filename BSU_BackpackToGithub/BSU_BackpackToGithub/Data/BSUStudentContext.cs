using Microsoft.EntityFrameworkCore;
using BSU_BackpackToGithub.Models;
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
    }
}

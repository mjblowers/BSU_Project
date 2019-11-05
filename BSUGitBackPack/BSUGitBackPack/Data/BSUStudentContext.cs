using Microsoft.EntityFrameworkCore;
using BSUGitBackPack.Models;

namespace BSUGitBackPack.Data
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

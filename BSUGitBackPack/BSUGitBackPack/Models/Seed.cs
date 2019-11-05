using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BSUGitBackPack.Data;
using System;
using System.Linq;

namespace BSUGitBackPack.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BSUStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BSUStudentContext>>()))
            {
                // Look for any movies.
                if (context.Class.Any())
                {
                    return;   // DB has been seeded
                }

                context.Class.AddRange(
                    new Class
                    {
                        Prefix = "CS",
                        Number = 453,
                        Semester = "F",
                        Year = 18
                        
                    },

                    new Class
                    {
                        Prefix = "CS",
                        Number = 481,
                        Semester = "S",
                        Year = 19
                    },

                    new Class
                    {
                        Prefix = "CS-HU",
                        Number = 250,
                        Semester = "Su",
                        Year = 19
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
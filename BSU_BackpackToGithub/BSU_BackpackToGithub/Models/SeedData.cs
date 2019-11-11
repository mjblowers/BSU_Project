using BSU_BackpackToGithub.Data;
using BSU_BackPackToGithub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_BackpackToGithub.Models
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
                        Name = "CS-453-1-F18"
                    },

                    new Class
                    {
                        Name = "CS-253-4-S19"
                    },

                    new Class
                    {
                        Name = "CSHU-250-2-SU20"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

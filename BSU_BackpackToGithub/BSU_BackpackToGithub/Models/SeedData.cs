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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BSU_BackpackToGithub.Data;
using System;
using System.Linq;

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
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        BSU_Username = "joebobsmith@u.boisestate.edu",
                        GitHub_Username = "joe1234",
                        First_Name = "Joebob",
                        Last_Name = "Smith",
                        Repo = "https://github.com/joe1234/CSHU-253-1-F18.git",
                        CourseName = "CSHU-253-1-F18"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

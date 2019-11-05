using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BSUGitBackPack.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(16, MinimumLength = 2)]
        [Required]
        public string BSU_Username { get; set; }

        [StringLength(39, MinimumLength = 1)]
        [RegularExpression(@"^[a-z0-9](?:-?[a-z0-9]")]
        [Required]
        public string GitHub_Username { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-z]")]
        [Required]
        public string First_Name { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-z]")]
        [Required]
        public string Last_Name { get; set; }

        [StringLength(78, MinimumLength = 36)]
        [Required]
        public string Repo { get; set; }

        [Required]
        [ForeignKey("ClassForeignKey")]
        public int ClassFK { get; set; }
    }
}

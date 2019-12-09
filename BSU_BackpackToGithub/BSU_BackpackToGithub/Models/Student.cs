using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_BackpackToGithub.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string BSU_Username { get; set; }

        [StringLength(39, MinimumLength = 1)]
        [RegularExpression("^[a-z0-9]+[-]?[a-z0-9]+")]
        [Required]
        public string GitHub_Username { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [RegularExpression("^[A-Z][a-z]+")]
        [Required]
        public string First_Name { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [RegularExpression("^[A-Z][a-z]+")]
        [Required]
        public string Last_Name { get; set; }

        [RegularExpression("^https://github.com/[a-z0-9]+[-]?[a-z0-9]+/C(S|SHU)-[1-9][0-9][0-9]-[1-9]-(F|S|SU)[0-9][0-9].git")]
        [Required]
        public string Repo { get; set; }

        [RegularExpression("^C(S|SHU)-[1-9][0-9][0-9]-[1-9]-(F|S|SU)[0-9][0-9]")]
        [Required]
        public string CourseName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_BackPackToGithub.Models
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

        [StringLength(78, MinimumLength = 36)]
        [Required]
        public string Repo { get; set; }

        [Required]
        [ForeignKey("Class")]
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }

        [RegularExpression("[CS|CSHU][-][100-499][-][]1-9][-][F|S|SU][00-99]")]
        [Required]
        public string Name { get; set; }

    }
}

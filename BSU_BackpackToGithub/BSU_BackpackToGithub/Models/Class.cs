using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_BackPackToGithub.Models
{
    public class Class
    {
        public int Id { get; set; }

        [StringLength(5, MinimumLength = 2)]
        [Required]
        public string Prefix { get; set; }

        [Range(100, 699)]
        [Required]
        public int Number { get; set; }

        [StringLength(2, MinimumLength = 1)]
        [RegularExpression(@"[F|f|S|s|Su|su]")]
        [Required]
        public string Semester { get; set; }

        [Range(00, 99)]
        [Required]
        public int Year { get; set; }
    }
}

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

        [RegularExpression("[CS|CSHU][-][100-499][-][]1-9][-][F|S|SU][00-99]")]
        [Required]
        public string Name { get; set; }

    }
}

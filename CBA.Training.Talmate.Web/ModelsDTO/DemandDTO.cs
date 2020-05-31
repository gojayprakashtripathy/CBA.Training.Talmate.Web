using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Web.ViewModels
{
    public class DemandDTO
    {
        [Key]
        public int DemandId { get; set; }
        [Required]
        public String PrimarySkill { get; set; }
        [Required]
        public String SecondarySkill { get; set; }
        [Required]
        public DateTime StartByDate { get; set; }
        [Required]
        public float ExperienceInYears { get; set; }
        public String Location { get; set; }
    }
}

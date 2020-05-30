using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Web.Models
{
    public class DemandRequirement
    {
        public int DemandId { get; set; }

        public String PrimarySkill { get; set; }

        public String SecondarySkill { get; set; }

        public DateTime StartByDate { get; set; }

        public float ExperienceInYears { get; set; }
        public String Location { get; set; }
    }
}

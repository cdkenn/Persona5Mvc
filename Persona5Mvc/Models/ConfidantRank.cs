using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persona5Mvc.Models
{
    public class ConfidantRank
    {
        public int ID { get; set; }

        [Display(Name = "Rank")]
        public int Level { get; set; }

        [Display(Name = "Perk")]
        public string PerkName { get; set; }

        [Display(Name = "Description")]
        public string PerkDescription { get; set; }

        [Display(Name = "Points to Next Level")]
        public int PointsToLevel { get; set; }
        public string Details { get; set; }
        public virtual ICollection<ConfidantRankDialogue> Dialogues { get; set; }
        public int ConfidantID { get; set; }

        public ConfidantRank()
        {
            Dialogues = new List<ConfidantRankDialogue>();
        }
    }
}
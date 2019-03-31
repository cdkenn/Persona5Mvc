using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persona5Mvc.Models
{
    public class ConfidantRank
    {
        public int ID { get; set; }
        public int Level { get; set; }

        [Display(Name = "Perk")]
        public string PerkName { get; set; }
        public string PerkDescription { get; set; }

        [Display(Name = "Points to Next Level")]
        public int PointsToLevel { get; set; }
        public string Details { get; set; }
        public virtual ICollection<ConfidantRankDialogue> Dialogues { get; set; }

        public ConfidantRank()
        {
            Dialogues = new List<ConfidantRankDialogue>();
        }
    }
}
using System.Collections.Generic;namespace Persona5Mvc.Models
{
    public class ConfidantRank
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public string PerkName { get; set; }
        public string PerkDescription { get; set; }
        public int PointsToLevel { get; set; }
        public string Details { get; set; }
        public virtual ICollection<ConfidantRankDialogue> Dialogues { get; set; }

        public ConfidantRank()
        {
            Dialogues = new List<ConfidantRankDialogue>();
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persona5Mvc.Models
{
    public class ConfidantRankDialogue
    {
        public int ID { get; set; }

        [Display(Name = "Previous Dialogue")]
        public string TextBeforeOptions { get; set; }

        [Range(1, 10)]
        public int DialogueOrder { get; set; }
        public virtual ICollection<DialogueOption> Options { get; set; }
        public int ConfidantRankID { get; set; }

        public ConfidantRankDialogue()
        {
            Options = new List<DialogueOption>();
        }
    }
}
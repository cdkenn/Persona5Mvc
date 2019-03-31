using System.Collections.Generic;

namespace Persona5Mvc.Models
{
    public class ConfidantRankDialogue
    {
        public int ID { get; set; }
        public string TextBeforeOptions { get; set; }
        public virtual ICollection<DialogueOption> Options { get; set; }

        public ConfidantRankDialogue()
        {
            Options = new List<DialogueOption>();
        }
    }
}
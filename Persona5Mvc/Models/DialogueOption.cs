using System.ComponentModel.DataAnnotations;

namespace Persona5Mvc.Models
{
    public class DialogueOption
    {
        public int ID { get; set; }

        [Display(Name = "Option")]
        public string OptionText { get; set; }

        [Display(Name = "Points")]
        [DisplayFormat(DataFormatString = "{0:+#;-#;0}")]
        public int PointsGiven { get; set; }

        public int ConfidantRankDialogueID { get; set; }
    }
}
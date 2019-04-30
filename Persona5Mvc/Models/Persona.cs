using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Persona5Mvc.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
        public string Arcana { get; set; }
        [Range(1, 99)]
        [Display(Name="Strength")]
        public int BaseStrength { get; set; }
        [Range(1, 99)]
        [Display(Name = "Magic")]
        public int BaseMagic { get; set; }
        [Range(1, 99)]
        [Display(Name = "Endurance")]
        public int BaseEndurance { get; set; }
        [Range(1, 99)]
        [Display(Name = "Agility")]
        public int BaseAgility { get; set; }
        [Range(1, 99)]
        [Display(Name = "Luck")]
        public int BaseLuck { get; set; }
    }
}
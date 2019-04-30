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
        public int BaseStrength { get; set; }
        [Range(1, 99)]
        public int BaseMagic { get; set; }
        [Range(1, 99)]
        public int BaseEndurance { get; set; }
        [Range(1, 99)]
        public int BaseAgility { get; set; }
        [Range(1, 99)]
        public int BaseLuck { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Persona5Mvc.Models
{
    public class DialogueOption
    {
        public int ID { get; set; }
        public string OptionText { get; set; }
        public int PointsGiven { get; set; }
    }

    public class DialogueOptionDBContext : DbContext
    {
        public DbSet<DialogueOption> DialogueOptions { get; set; }
    }
}
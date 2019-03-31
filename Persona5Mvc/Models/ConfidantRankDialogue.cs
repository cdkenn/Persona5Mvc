﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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

    public class ConfidantRankDialogueDBContext : DbContext
    {
        public DbSet<ConfidantRankDialogue> ConfidantRankDialogues { get; set; }
    }
}
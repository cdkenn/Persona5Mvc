namespace Persona5Mvc.Migrations
{
    using Persona5Mvc.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Persona5Mvc.Models.ConfidantDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Persona5Mvc.Models.ConfidantDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Confidants.AddOrUpdate(i => i.Arcana,
                new Confidant
                {
                    Name = "Ryuji",
                    Arcana = "Chariot",
                    DateAvailable = DateTime.Parse("April 12"),
                    DaysAvailable = "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday",
                    TimeOfDayAvailable = "Afternoon",
                    Location = "Shujin 2F, Shibuya Arcade",
                    Ranks = new List<ConfidantRank>
                    {
                        new ConfidantRank
                        {
                            Level = 1,
                            PointsToLevel = 0,
                            PerkName = "",
                            PerkDescription = "",
                            Details = "On 4/12, after checking out the situation in the old castle you automatically start this cooperation."
                        },
                        new ConfidantRank
                        {
                            Level = 2,
                            PointsToLevel = 0,
                            PerkName = "Baton Pass",
                            PerkDescription = "Unlock Baton Pass with Ryuji",
                            Details = "",
                            Dialogues = new List<ConfidantRankDialogue>
                            {
                                new ConfidantRankDialogue
                                {
                                    Options = new List<DialogueOption>
                                    {
                                        new DialogueOption
                                        {
                                            OptionText = "I'm counting on you.",
                                            PointsGiven = 3
                                        },
                                        new DialogueOption
                                        {
                                            OptionText = "You seem pretty excited.",
                                            PointsGiven = 3
                                        },
                                        new DialogueOption
                                        {
                                            OptionText = "…Help with what?",
                                            PointsGiven = 2
                                        },
                                    }
                                }
                            }
                        },
                    }
                }
            );
        }
    }
}

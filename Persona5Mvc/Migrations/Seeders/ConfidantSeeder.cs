using Persona5Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Persona5Mvc.Migrations.Seeders
{
    public class ConfidantSeeder
    {
        public void Seed(ConfidantDBContext context)
        {
            context.Confidants.AddOrUpdate(i => i.Arcana,
                GenerateFoolConfidant(),
                GenerateMagicianConfidant(),
                GeneratePriestessConfidant(),
                GenerateEmpressConfidant(),
                GenerateEmperorConfidant(),
                GenerateHeriophantConfidant(),
                GenerateLoversConfidant(),
                GenerateChariotConfidant(),
                GenerateJusticeConfidant(),
                GenerateHermitConfidant(),
                GenerateFortuneConfidant(),
                GenerateStrengthConfidant(),
                GenerateHangedConfidant(),
                GenerateDeathConfidant(),
                GenerateTemperanceConfidant(),
                GenerateDevilConfidant(),
                GenerateTowerConfidant(),
                GenerateStarConfidant(),
                GenerateMoonConfidant(),
                GenerateSunConfidant(),
                GenerateJusticeConfidant()
            );
        }

        private Confidant GenerateFoolConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Fool",
                Name = "Igor",
                DateAvailable = DateTime.Parse("April 12"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateMagicianConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Magician",
                Name = "Morgana",
                DateAvailable = DateTime.Parse("April 15"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GeneratePriestessConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Priestess",
                Name = "Makoto Nijima",
                DateAvailable = DateTime.Parse("June 24"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateEmpressConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Empress",
                Name = "Haru Okumura",
                DateAvailable = DateTime.Parse("October 30"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateEmperorConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Emperor",
                Name = "Yusuke Kitagawa",
                DateAvailable = DateTime.Parse("June 18"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateHeriophantConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Heirophant",
                Name = "Sojiro Sakura",
                DateAvailable = DateTime.Parse("April 24"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateLoversConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Lovers",
                Name = "Ann Takemi",
                DateAvailable = DateTime.Parse("May 6"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateChariotConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Chariot",
                Name = "Ryuji Sakamoto",
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
            };
            return confidant;
        }

        private Confidant GenerateJusticeConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Justice",
                Name = "Goro Akechi",
                DateAvailable = DateTime.Parse("June 10"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateHermitConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Hermit",
                Name = "Futaba Sakura",
                DateAvailable = DateTime.Parse("September 2"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateFortuneConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Fortune",
                Name = "Chihaya Mifune",
                DateAvailable = DateTime.Parse("June 19"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateStrengthConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Strength",
                Name = "Justine and Caroline",
                DateAvailable = DateTime.Parse("May 18"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateHangedConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Hanged Man",
                Name = "Munehisa Iwai",
                DateAvailable = DateTime.Parse("May 6"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateDeathConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Death",
                Name = "Tae Takemi",
                DateAvailable = DateTime.Parse("April 18"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateTemperanceConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Temperance",
                Name = "Sadayo Kawakami",
                DateAvailable = DateTime.Parse("May 24"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateDevilConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Devil",
                Name = "Ichiko Ohya",
                DateAvailable = DateTime.Parse("June 22"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateTowerConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Tower",
                Name = "Shinya Oda",
                DateAvailable = DateTime.Parse("September 4"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateStarConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Star",
                Name = "Hifumi Togo",
                DateAvailable = DateTime.Parse("June 25"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateMoonConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Moon",
                Name = "Yuuki Mishima",
                DateAvailable = DateTime.Parse("May 6"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateSunConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Sun",
                Name = "Toranosuke Yoshida",
                DateAvailable = DateTime.Parse("May 6"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }

        private Confidant GenerateJudgementConfidant()
        {
            var confidant = new Confidant
            {
                Arcana = "Judgement",
                Name = "Sae Nijima",
                DateAvailable = DateTime.Parse("July 9"),
                Ranks = new List<ConfidantRank> { }
            };
            return confidant;
        }
    }
}
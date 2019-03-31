namespace Persona5Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initconfidants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Confidants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Arcana = c.String(),
                        Details = c.String(),
                        DateAvailable = c.DateTime(nullable: false),
                        DaysAvailable = c.String(),
                        TimeOfDayAvailable = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ConfidantRanks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        PerkName = c.String(),
                        PerkDescription = c.String(),
                        PointsToLevel = c.Int(nullable: false),
                        Details = c.String(),
                        Confidant_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Confidants", t => t.Confidant_ID)
                .Index(t => t.Confidant_ID);
            
            CreateTable(
                "dbo.ConfidantRankDialogues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TextBeforeOptions = c.String(),
                        ConfidantRank_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ConfidantRanks", t => t.ConfidantRank_ID)
                .Index(t => t.ConfidantRank_ID);
            
            CreateTable(
                "dbo.DialogueOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OptionText = c.String(),
                        PointsGiven = c.Int(nullable: false),
                        ConfidantRankDialogue_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ConfidantRankDialogues", t => t.ConfidantRankDialogue_ID)
                .Index(t => t.ConfidantRankDialogue_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConfidantRanks", "Confidant_ID", "dbo.Confidants");
            DropForeignKey("dbo.ConfidantRankDialogues", "ConfidantRank_ID", "dbo.ConfidantRanks");
            DropForeignKey("dbo.DialogueOptions", "ConfidantRankDialogue_ID", "dbo.ConfidantRankDialogues");
            DropIndex("dbo.DialogueOptions", new[] { "ConfidantRankDialogue_ID" });
            DropIndex("dbo.ConfidantRankDialogues", new[] { "ConfidantRank_ID" });
            DropIndex("dbo.ConfidantRanks", new[] { "Confidant_ID" });
            DropTable("dbo.DialogueOptions");
            DropTable("dbo.ConfidantRankDialogues");
            DropTable("dbo.ConfidantRanks");
            DropTable("dbo.Confidants");
        }
    }
}

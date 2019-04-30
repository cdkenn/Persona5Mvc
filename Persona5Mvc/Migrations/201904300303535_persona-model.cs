namespace Persona5Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personamodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Level = c.Int(nullable: false),
                        Arcana = c.String(),
                        BaseStrength = c.Int(nullable: false),
                        BaseMagic = c.Int(nullable: false),
                        BaseEndurance = c.Int(nullable: false),
                        BaseAgility = c.Int(nullable: false),
                        BaseLuck = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}

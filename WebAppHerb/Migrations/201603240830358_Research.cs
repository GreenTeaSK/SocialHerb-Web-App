namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Research : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Researches",
                c => new
                    {
                        researchID = c.String(nullable: false, maxLength: 128),
                        researchName = c.String(),
                        researchLink = c.String(),
                        herbID = c.String(),
                    })
                .PrimaryKey(t => t.researchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Researches");
        }
    }
}

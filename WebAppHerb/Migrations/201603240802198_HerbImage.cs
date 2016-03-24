namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HerbImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HerbImages",
                c => new
                    {
                        herbImageID = c.String(nullable: false, maxLength: 128),
                        herbID = c.String(),
                        shootTip = c.String(),
                        groundTissue = c.String(),
                        leaf = c.String(),
                        flower = c.String(),
                        seeds = c.String(),
                        root = c.String(),
                    })
                .PrimaryKey(t => t.herbImageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HerbImages");
        }
    }
}

namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herb2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Herbs", "herbResearch");
            DropColumn("dbo.Herbs", "herbResearchName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Herbs", "herbResearchName", c => c.String());
            AddColumn("dbo.Herbs", "herbResearch", c => c.String());
        }
    }
}

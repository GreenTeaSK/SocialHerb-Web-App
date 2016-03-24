namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Herbs", "herbResearchName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Herbs", "herbResearchName");
        }
    }
}

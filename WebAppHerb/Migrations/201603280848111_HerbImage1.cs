namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HerbImage1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HerbImages", "herbName", c => c.String());
            AddColumn("dbo.Researches", "herbName", c => c.String());
            DropColumn("dbo.HerbImages", "herbID");
            DropColumn("dbo.Researches", "herbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Researches", "herbID", c => c.String());
            AddColumn("dbo.HerbImages", "herbID", c => c.String());
            DropColumn("dbo.Researches", "herbName");
            DropColumn("dbo.HerbImages", "herbName");
        }
    }
}

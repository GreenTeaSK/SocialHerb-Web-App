namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ratings", "herbName", c => c.String());
            DropColumn("dbo.Ratings", "herbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ratings", "herbID", c => c.String());
            DropColumn("dbo.Ratings", "herbName");
        }
    }
}

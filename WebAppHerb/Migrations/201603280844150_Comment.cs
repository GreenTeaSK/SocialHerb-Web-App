namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "herbName", c => c.String());
            DropColumn("dbo.Comments", "herbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "herbID", c => c.String());
            DropColumn("dbo.Comments", "herbName");
        }
    }
}

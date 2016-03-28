namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Disease3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Diseases", "herbName", c => c.String());
            DropColumn("dbo.Diseases", "herbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Diseases", "herbID", c => c.String());
            DropColumn("dbo.Diseases", "herbName");
        }
    }
}

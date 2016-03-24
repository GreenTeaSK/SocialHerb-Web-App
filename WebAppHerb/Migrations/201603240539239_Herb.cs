namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Herbs", "herbNameOther", c => c.String());
            AddColumn("dbo.Herbs", "herbResearch", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Herbs", "herbResearch");
            DropColumn("dbo.Herbs", "herbNameOther");
        }
    }
}

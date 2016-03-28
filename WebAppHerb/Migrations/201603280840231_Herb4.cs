namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herb4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Herbs", "herbName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Herbs");
            AddPrimaryKey("dbo.Herbs", "herbName");
            DropColumn("dbo.Herbs", "herbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Herbs", "herbID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Herbs");
            AddPrimaryKey("dbo.Herbs", "herbID");
            AlterColumn("dbo.Herbs", "herbName", c => c.String());
        }
    }
}

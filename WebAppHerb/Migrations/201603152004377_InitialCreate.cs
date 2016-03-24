namespace WebAppHerb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        articleID = c.String(nullable: false, maxLength: 128),
                        articleName = c.String(),
                        articleDetail = c.String(),
                        articleReference = c.String(),
                        articleImage = c.String(),
                    })
                .PrimaryKey(t => t.articleID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        commentID = c.String(nullable: false, maxLength: 128),
                        date = c.DateTime(nullable: false),
                        username = c.String(),
                        herbID = c.String(),
                        herbComment = c.String(),
                        diseaseID = c.String(),
                        diseaseComment = c.String(),
                    })
                .PrimaryKey(t => t.commentID);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        diseaseID = c.String(nullable: false, maxLength: 128),
                        diseaseName = c.String(),
                        syntom = c.String(),
                        herbID = c.String(),
                    })
                .PrimaryKey(t => t.diseaseID);
            
            CreateTable(
                "dbo.Herbs",
                c => new
                    {
                        herbID = c.String(nullable: false, maxLength: 128),
                        herbName = c.String(),
                        herbDetail = c.String(),
                        herbProperties = c.String(),
                        herbHowto = c.String(),
                        herbDirect = c.String(),
                        herbImage = c.String(),
                    })
                .PrimaryKey(t => t.herbID);
            
            CreateTable(
                "dbo.Infographics",
                c => new
                    {
                        infographicID = c.String(nullable: false, maxLength: 128),
                        infographicName = c.String(),
                        InfographicReference = c.String(),
                        infographicImage = c.String(),
                    })
                .PrimaryKey(t => t.infographicID);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        username = c.String(),
                        password = c.String(),
                        name = c.String(),
                        lastname = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ratingID = c.String(nullable: false, maxLength: 128),
                        herbID = c.String(),
                        herbRating = c.String(),
                        articleID = c.String(),
                        articleRating = c.String(),
                    })
                .PrimaryKey(t => t.ratingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ratings");
            DropTable("dbo.Pharmacists");
            DropTable("dbo.Infographics");
            DropTable("dbo.Herbs");
            DropTable("dbo.Diseases");
            DropTable("dbo.Comments");
            DropTable("dbo.Articles");
        }
    }
}

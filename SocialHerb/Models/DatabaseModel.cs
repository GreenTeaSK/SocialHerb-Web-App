using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialHerb.Models
{
    public class DatabaseModel
    {
    }

    public class Herb
    {
        [Key]
        [Display(Name = "ชื่อสมุนไพร")]
        public string herbName { get; set; }

        [Display(Name = "ชื่ออื่นๆ")]
        public string nameOther { get; set; }

        [Display(Name = "ภาพสมุนไพร")]
        public string herbImg { get; set; }

        [Display(Name = "ใบ")]
        public string leafImg { get; set; }

        [Display(Name = "ลักษณะใบ")]
        public string leaf { get; set; }

        [Display(Name = "ลำต้น")]
        public string trunkImg { get; set; }

        [Display(Name = "ลักษณะลำต้น")]
        public string trunk { get; set; }

        [Display(Name = "ราก")]
        public string rootImg { get; set; }

        [Display(Name = "ลักษณะราก")]
        public string root { get; set; }

        [Display(Name = "ผลของพืช")]
        public string cropImg { get; set; }

        [Display(Name = "ลักษณะผลของพืช")]
        public string crop { get; set; }

        [Display(Name = "หัวของพืช")]
        public string cormImg { get; set; }

        [Display(Name = "ลักษณะหัวของพืช")]
        public string corm { get; set; }

        [Display(Name = "ดอก")]
        public string flowerImg { get; set; }

        [Display(Name = "ลักษณะดอก")]
        public string flower { get; set; }
    }

    public class HerbDetail
    {
        [Key]
        public string detailID { get; set; }

        [Display(Name ="ชื่อสมุนไพร")]
        public string herbName { get; set; }

        [Display(Name ="สรรพคุณ")]
        public string properties { get; set; }

        [Display(Name ="วิธีใช้")]
        public string help { get; set; }

        [Display(Name ="ข้อควรระวัง")]
        public string warning { get; set; }

        [Display(Name ="ชื่องานวิจัย")]
        public string researchName { get; set; }

        [Display(Name ="เนื้อหางานวิจัย")]
        public string research { get; set; }

        [Display(Name ="ชื่อผู้วิจัย")]
        public string author { get; set; }
    }

    public class Disease
    {
        [Key]
        public string diseaseID { get; set; }

        [Display(Name = "ชื่อโรค")]
        public string diseaseName { get; set; }

        [Display(Name = "อาการ")]
        public string syntom { get; set; }

        [Display(Name = "สมุนไพรที่เกี่ยวข้อง")]
        public string herbName { get; set; }
    }

    public class Article
    {
        [Key]
        public string articleID { get; set; }

        [Display(Name = "ชื่อบทความ")]
        public string articleName { get; set; }

        [Display(Name = "เนื้อหาของบทความ")]
        public string articleDetail { get; set; }

        [Display(Name = "ที่มา")]
        public string articleReference { get; set; }

        [Display(Name = "ภาพประกอบ")]
        public string articleImage { get; set; }
    }

    public class Infographic
    {
        [Key]
        public string infoID { get; set; }

        [Display(Name = "ชื่อ Infographic")]
        public string infoName { get; set; }

        [Display(Name = "ที่มา")]
        public string InfoReference { get; set; }

        [Display(Name = "ภาพ Infographic")]
        public string infoImage { get; set; }
    }

    public class Rating
    {
        [Key]
        public string ratingID { get; set; }
        public string herbName { get; set; }
        public string herbRating { get; set; }
        public string articleID { get; set; }
        public string articleRating { get; set; }
    }

    public class HerbDBContext : DbContext
    {
        public DbSet<Herb> Herbs { get; set; }
        public DbSet<HerbDetail> HerbDetails { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Infographic> Infographics { get; set; }
        public DbSet<Rating> Rating { get; set; }
    }
}
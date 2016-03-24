using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppHerb.Models
{
    public class Database
    {
    }

    public class Herb
    {
        public string herbID { get; set; }

        [Display(Name="ชื่อสมุนไพร")]
        public string herbName { get; set; }

        [Display(Name="ลักษณะของสมุนไพร")]
        public string herbDetail { get; set; }

        [Display(Name="สรรพคุณสมุนไพร")]
        public string herbProperties { get; set; }

        [Display(Name="วิธีใช้")]
        public string herbHowto { get; set; }

        [Display(Name="คำแนะนำ")]
        public string herbDirect { get; set; }

        [Display(Name = "ภาพสมุนไพร")]
        public string herbImage { get; set; }

        [Display(Name = "ชื่ออื่นๆ")]
        public string herbNameOther { get; set; }
    }

    public class Disease
    {
        public string diseaseID { get; set; }

        [Display(Name = "ชื่อโรค")]
        public string diseaseName { get; set; }

        [Display(Name = "อาการ")]
        public string syntom { get; set; }

        [Display(Name = "สมุนไพรที่เกี่ยวข้อง")]
        public string herbID { get; set; }
    }

    public class Article
    {
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
        public string infographicID { get; set; }

        [Display(Name = "ชื่อ Infographic")]
        public string infographicName { get; set; }

        [Display(Name = "ที่มา")]
        public string InfographicReference { get; set; }

        [Display(Name = "ภาพ Infographic")]
        public string infographicImage { get; set; }
    }

    public class Pharmacist
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
    }

    public class Comment
    {
        public string commentID { get; set; }
        public DateTime date { get; set; }
        public string username { get; set; }
        public string herbID { get; set; }
        public string herbComment { get; set; }
        public string diseaseID { get; set; }
        public string diseaseComment { get; set; }
    }
    public class Rating
    {
        public string ratingID { get; set; }
        public string herbID { get; set; }
        public string herbRating { get; set; }
        public string articleID { get; set; }
        public string articleRating { get; set; }
    }

    public class HerbImage
    {
        public string herbImageID { get; set; }

        [Display(Name = "ชื่อสมุนไพร")]
        public string herbID { get; set; }

        [Display(Name = "รูปของส่วนยอด")]
        public string shootTip { get; set; }

        [Display(Name = "รูปของส่วนลำต้น")]
        public string groundTissue { get; set; }

        [Display(Name = "รูปของส่วนใบ")]
        public string leaf { get; set; }

        [Display(Name = "รูปของส่วนดอก")]
        public string flower { get; set; }

        [Display(Name = "รูปของส่วนผล/เมล็ด")]
        public string seeds { get; set; }

        [Display(Name = "รูปของส่วนราก/หัว")]
        public string root { get; set; }
    }

    public class Research
    {
        public string researchID { get; set; }

        [Display(Name = "ชื่องานวิจัย")]
        public string researchName { get; set; }

        [Display(Name = "URL งานวิจัย")]
        public string researchLink { get; set; }

        [Display(Name = "สมุนไพรที่วิจัย")]
        public string herbID { get; set; }
    }

    public class WebAppHerbDBContext : DbContext
    {
        public DbSet<Herb> Herbs { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Infographic> Infographics { get; set; }
        public DbSet<Pharmacist> Pharmacists { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<HerbImage> HerbImages { get; set; }
        public DbSet<Research> Researchs { get; set; }
    }
}
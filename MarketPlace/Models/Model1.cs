namespace MarketPlace.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblCredential> tblCredentials { get; set; }
        public virtual DbSet<tblManufacturer> tblManufacturers { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductDetail> tblProductDetails { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<tblCredential>()
                .Property(e => e.User_Type)
                .IsUnicode(false);

            modelBuilder.Entity<tblManufacturer>()
                .Property(e => e.Manufacturer_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Fan_Speed_Min)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Power_Min)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Series)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Model_Year)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Airflow)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Operating_Voltage_Min)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Accessories)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Fan_Sweep_Diameter)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Sound_Max_Speed)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Picture)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Power_Max)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Operating_Voltage_Max)
                .IsUnicode(false);

            modelBuilder.Entity<tblProductDetail>()
                .Property(e => e.Fan_Speed_Max)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.imagepath)
                .IsUnicode(false);
        }
    }
}

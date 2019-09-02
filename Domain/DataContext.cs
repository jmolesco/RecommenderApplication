using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        #region  SCHOOL
        public DbSet<School.School> School { get; set; }
        public DbSet<School.StrandCategory> StrandCategory { get; set; }
        public DbSet<School.TrackCategory> TrackCategory { get; set; }
        #endregion

        #region  TAXONOMY
        public DbSet<Taxonomy.CityMunicipality> CityMunicipality { get; set; }
        public DbSet<Taxonomy.Province> Province { get; set; }
        public DbSet<Taxonomy.Region> Region { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetDefaultValues(modelBuilder);
            SetIndexColumn(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        private void SetDefaultValues(ModelBuilder modelBuilder)
        {
            #region SCHOOL
            modelBuilder.Entity<School.School>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<School.StrandCategory>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<School.TrackCategory>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            #endregion

            #region TAXONOMY
            modelBuilder.Entity<Taxonomy.CityMunicipality>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<Taxonomy.Province>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<Taxonomy.Region>().Property(p => p.DateCreated).
            HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            #endregion
        }

        private void SetIndexColumn(ModelBuilder modelBuilder)
        {
            #region SCHOOL
            modelBuilder.Entity<School.School>()
                .HasIndex(p =>
                 new
                 {
                     p.SchoolID,
                 });
            modelBuilder.Entity<School.StrandCategory>()
                .HasIndex(p =>
                 new
                 {
                     p.StrandCategoryID,
                 });
            modelBuilder.Entity<School.TrackCategory>()
                .HasIndex(p =>
                 new
                 {
                     p.TrackCategoryID,
                 });

            #endregion
            #region TAXONOMY
            modelBuilder.Entity<Taxonomy.CityMunicipality>()
                .HasIndex(p =>
                 new
                 {
                     p.CityMunicipalityID,
                 });
            modelBuilder.Entity<Taxonomy.Province>()
                .HasIndex(p =>
                 new
                 {
                     p.ProvinceID,
                 });

            modelBuilder.Entity<Taxonomy.Region>()
                .HasIndex(p =>
                 new
                 {
                     p.RegionID,
                 });
            #endregion
        }
    }
}

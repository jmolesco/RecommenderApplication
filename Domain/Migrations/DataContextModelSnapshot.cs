﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.School.School", b =>
                {
                    b.Property<int>("SchoolID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityMunicipalityID");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("HouseNumber");

                    b.Property<string>("ImageFileName")
                        .HasMaxLength(255);

                    b.Property<int>("ProvinceID");

                    b.Property<int>("RegionID");

                    b.Property<string>("SchoolCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("Status");

                    b.Property<string>("StreetName");

                    b.Property<string>("StreetType");

                    b.HasKey("SchoolID");

                    b.HasIndex("SchoolID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("Domain.School.StrandCategory", b =>
                {
                    b.Property<int>("StrandCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NationalCertificate")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<bool>("Status");

                    b.Property<string>("StrandCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("StrandName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("TrackCategoryID");

                    b.HasKey("StrandCategoryID");

                    b.HasIndex("StrandCategoryID");

                    b.ToTable("StrandCategory");
                });

            modelBuilder.Entity("Domain.School.TrackCategory", b =>
                {
                    b.Property<int>("TrackCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("Status");

                    b.Property<string>("TrackCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("TrackCategoryID");

                    b.HasIndex("TrackCategoryID");

                    b.ToTable("TrackCategory");
                });

            modelBuilder.Entity("Domain.Taxonomy.CityMunicipality", b =>
                {
                    b.Property<int>("CityMunicipalityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityMunicipalityCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("CityMunicipalityName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ProvinceID");

                    b.Property<int>("RegionID");

                    b.Property<bool>("Status");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("CityMunicipalityID");

                    b.HasIndex("CityMunicipalityID");

                    b.ToTable("CityMunicipality");
                });

            modelBuilder.Entity("Domain.Taxonomy.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ProvinceCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("RegionID");

                    b.Property<bool>("Status");

                    b.HasKey("ProvinceID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("Domain.Taxonomy.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RegionCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("Status");

                    b.HasKey("RegionID");

                    b.HasIndex("RegionID");

                    b.ToTable("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
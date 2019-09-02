using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Phase1_SetUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityMunicipality",
                columns: table => new
                {
                    CityMunicipalityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    CityMunicipalityCode = table.Column<string>(maxLength: 25, nullable: false),
                    CityMunicipalityName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 25, nullable: false),
                    RegionID = table.Column<int>(nullable: false),
                    ProvinceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMunicipality", x => x.CityMunicipalityID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ProvinceCode = table.Column<string>(maxLength: 25, nullable: false),
                    ProvinceName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    RegionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    RegionCode = table.Column<string>(maxLength: 25, nullable: false),
                    RegionName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolID = table.Column<int>(maxLength: 255, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    SchoolCode = table.Column<string>(maxLength: 25, nullable: false),
                    SchoolName = table.Column<string>(maxLength: 255, nullable: false),
                    ImageFileName = table.Column<string>(maxLength: 255, nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    StreetType = table.Column<string>(nullable: true),
                    RegionID = table.Column<int>(nullable: false),
                    ProvinceID = table.Column<int>(nullable: false),
                    CityMunicipalityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "StrandCategory",
                columns: table => new
                {
                    StrandCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    StrandCode = table.Column<string>(maxLength: 25, nullable: false),
                    StrandName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    NationalCertificate = table.Column<string>(maxLength: 25, nullable: false),
                    TrackCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrandCategory", x => x.StrandCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "TrackCategory",
                columns: table => new
                {
                    TrackCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DateModified = table.Column<DateTime>(nullable: true),
                    TrackCode = table.Column<string>(maxLength: 25, nullable: false),
                    TrackName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackCategory", x => x.TrackCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityMunicipality_CityMunicipalityID",
                table: "CityMunicipality",
                column: "CityMunicipalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Province_ProvinceID",
                table: "Province",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Region_RegionID",
                table: "Region",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_School_SchoolID",
                table: "School",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_StrandCategory_StrandCategoryID",
                table: "StrandCategory",
                column: "StrandCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackCategory_TrackCategoryID",
                table: "TrackCategory",
                column: "TrackCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityMunicipality");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "StrandCategory");

            migrationBuilder.DropTable(
                name: "TrackCategory");
        }
    }
}

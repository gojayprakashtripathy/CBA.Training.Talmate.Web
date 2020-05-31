using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBA.Training.Talmate.Web.Migrations
{
    public partial class UpdateDemandRequirementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "demandrequirement",
                columns: table => new
                {
                    DemandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimarySkill = table.Column<string>(nullable: true),
                    SecondarySkill = table.Column<string>(nullable: true),
                    StartByDate = table.Column<DateTime>(nullable: false),
                    ExperienceInYears = table.Column<float>(nullable: false),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demandrequirement", x => x.DemandId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "demandrequirement");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenPlan.Data.Migrations
{
    public partial class Laptop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantCreateViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlantName = table.Column<string>(nullable: true),
                    PlantCategory = table.Column<int>(nullable: false),
                    PlantTime = table.Column<DateTime>(nullable: false),
                    HarvestTime = table.Column<DateTime>(nullable: false),
                    Sun = table.Column<int>(nullable: false),
                    Spacing = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    MinTemp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantCreateViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantDetailsViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlantName = table.Column<string>(nullable: true),
                    PlantCategory = table.Column<int>(nullable: false),
                    PlantTime = table.Column<DateTime>(nullable: false),
                    HarvestTime = table.Column<DateTime>(nullable: false),
                    Sun = table.Column<int>(nullable: false),
                    Spacing = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    MinTemp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantDetailsViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantCreateViewModel");

            migrationBuilder.DropTable(
                name: "PlantDetailsViewModel");
        }
    }
}

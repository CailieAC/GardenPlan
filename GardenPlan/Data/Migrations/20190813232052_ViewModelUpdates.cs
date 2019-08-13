using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenPlan.Data.Migrations
{
    public partial class ViewModelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantCreateViewModel");

            migrationBuilder.DropTable(
                name: "PlantDetailsViewModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantCreateViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<int>(nullable: false),
                    HarvestDate = table.Column<DateTime>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    MinTemp = table.Column<int>(nullable: false),
                    PlantCategory = table.Column<int>(nullable: false),
                    PlantDate = table.Column<DateTime>(nullable: false),
                    PlantName = table.Column<string>(nullable: true),
                    Spacing = table.Column<string>(nullable: true),
                    Sun = table.Column<int>(nullable: false)
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
                    Duration = table.Column<int>(nullable: false),
                    HarvestDate = table.Column<DateTime>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    MinTemp = table.Column<int>(nullable: false),
                    PlantCategory = table.Column<int>(nullable: false),
                    PlantDate = table.Column<DateTime>(nullable: false),
                    PlantName = table.Column<string>(nullable: true),
                    Spacing = table.Column<string>(nullable: true),
                    Sun = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantDetailsViewModel", x => x.Id);
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenPlan.Data.Migrations
{
    public partial class Plants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlantName = table.Column<string>(nullable: true),
                    PlantCategory = table.Column<int>(nullable: false),
                    PlantDate = table.Column<DateTime>(nullable: false),
                    HarvestDate = table.Column<DateTime>(nullable: false),
                    Sun = table.Column<int>(nullable: false),
                    Spacing = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    MaxTemp = table.Column<int>(nullable: false),
                    MinTemp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}

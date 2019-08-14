using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenPlan.Data.Migrations
{
    public partial class PlantDateHarvestDateChangeToTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlantTime",
                table: "Plants",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "HarvestTime",
                table: "Plants",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PlantTime",
                table: "Plants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HarvestTime",
                table: "Plants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

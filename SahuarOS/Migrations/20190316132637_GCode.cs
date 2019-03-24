using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SahuarOS.Migrations
{
    public partial class GCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "GCode",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GCode",
                table: "Products");
        }
    }
}

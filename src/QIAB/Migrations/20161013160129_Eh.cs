using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QIAB.Migrations
{
    public partial class Eh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PotAnswer1",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PotAnswer2",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PotAnswer3",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PotAnswer1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PotAnswer2",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PotAnswer3",
                table: "Questions");
        }
    }
}

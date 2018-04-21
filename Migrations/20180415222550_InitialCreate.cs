using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BowllyForever.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Back",
                table: "vinyl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Front",
                table: "vinyl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Back",
                table: "cd",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Front",
                table: "cd",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inside",
                table: "cd",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Back",
                table: "cassette",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Front",
                table: "cassette",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Back",
                table: "vinyl");

            migrationBuilder.DropColumn(
                name: "Front",
                table: "vinyl");

            migrationBuilder.DropColumn(
                name: "Back",
                table: "cd");

            migrationBuilder.DropColumn(
                name: "Front",
                table: "cd");

            migrationBuilder.DropColumn(
                name: "Inside",
                table: "cd");

            migrationBuilder.DropColumn(
                name: "Back",
                table: "cassette");

            migrationBuilder.DropColumn(
                name: "Front",
                table: "cassette");
        }
    }
}

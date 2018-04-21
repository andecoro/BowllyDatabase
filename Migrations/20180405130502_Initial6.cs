using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BowllyForever.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cassette",
                columns: table => new
                {
                    CassetteID = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(maxLength: 50, nullable: true),
                    Cat_No = table.Column<string>(maxLength: 255, nullable: true),
                    Label = table.Column<string>(maxLength: 255, nullable: true),
                    Location = table.Column<string>(maxLength: 255, nullable: true),
                    Record_Co = table.Column<string>(maxLength: 50, nullable: true),
                    Released = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cassette", x => x.CassetteID);
                });

            migrationBuilder.CreateTable(
                name: "cd",
                columns: table => new
                {
                    CDID = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(maxLength: 50, nullable: true),
                    Cat_No = table.Column<string>(maxLength: 50, nullable: true),
                    Label = table.Column<string>(maxLength: 255, nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    Record_Co = table.Column<string>(maxLength: 50, nullable: true),
                    Released = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cd", x => x.CDID);
                });

            migrationBuilder.CreateTable(
                name: "track",
                columns: table => new
                {
                    TrackID = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(maxLength: 255, nullable: true),
                    Cat_No = table.Column<string>(maxLength: 255, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Label = table.Column<string>(maxLength: 255, nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    Matrix = table.Column<string>(maxLength: 50, nullable: true),
                    Music = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 255, nullable: true),
                    Words = table.Column<string>(maxLength: 50, nullable: true),
                    Youtube = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_track", x => x.TrackID);
                });

            migrationBuilder.CreateTable(
                name: "vinyl",
                columns: table => new
                {
                    VinylID = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(maxLength: 50, nullable: true),
                    Cat_No = table.Column<string>(maxLength: 50, nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    Record_Co = table.Column<string>(maxLength: 50, nullable: true),
                    Size = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Year = table.Column<string>(type: "nchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vinyl", x => x.VinylID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cassette");

            migrationBuilder.DropTable(
                name: "cd");

            migrationBuilder.DropTable(
                name: "track");

            migrationBuilder.DropTable(
                name: "vinyl");
        }
    }
}

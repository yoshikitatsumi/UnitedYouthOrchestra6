using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedYouthOrchestra6.Migrations
{
    public partial class UYO6DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Violin = table.Column<bool>(nullable: false),
                    Viola = table.Column<bool>(nullable: false),
                    Cello = table.Column<bool>(nullable: false),
                    DoubleBass = table.Column<bool>(nullable: false),
                    Flute = table.Column<bool>(nullable: false),
                    Oboe = table.Column<bool>(nullable: false),
                    Clarinet = table.Column<bool>(nullable: false),
                    Bassoon = table.Column<bool>(nullable: false),
                    Horn = table.Column<bool>(nullable: false),
                    Trumpet = table.Column<bool>(nullable: false),
                    Trombone = table.Column<bool>(nullable: false),
                    Tuba = table.Column<bool>(nullable: false),
                    TimpaniPerc = table.Column<bool>(nullable: false),
                    Keyboard = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year6orEarlier = table.Column<bool>(nullable: false),
                    Year7 = table.Column<bool>(nullable: false),
                    Year8 = table.Column<bool>(nullable: false),
                    Year9 = table.Column<bool>(nullable: false),
                    Year10 = table.Column<bool>(nullable: false),
                    Year11 = table.Column<bool>(nullable: false),
                    Year12 = table.Column<bool>(nullable: false),
                    Year13 = table.Column<bool>(nullable: false),
                    Other = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    SYearFK = table.Column<int>(nullable: false),
                    InstFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Instrument_InstFK",
                        column: x => x.InstFK,
                        principalTable: "Instrument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_SchoolYear_SYearFK",
                        column: x => x.SYearFK,
                        principalTable: "SchoolYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_InstFK",
                table: "Member",
                column: "InstFK");

            migrationBuilder.CreateIndex(
                name: "IX_Member_SYearFK",
                table: "Member",
                column: "SYearFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "SchoolYear");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserControl.Migrations
{
    public partial class ModelRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarManufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarManufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Cars_CarManufacturers",
                columns: table => new
                {
                    CarmanId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars_CarManufacturers", x => new { x.CarId, x.CarmanId });
                    table.ForeignKey(
                        name: "FK_Cars_CarManufacturers_CarManufacturers_CarmanId",
                        column: x => x.CarmanId,
                        principalTable: "CarManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarManufacturers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarManufacturers_CarmanId",
                table: "Cars_CarManufacturers",
                column: "CarmanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars_CarManufacturers");

            migrationBuilder.DropTable(
                name: "CarManufacturers");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}

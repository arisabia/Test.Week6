using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeek6.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CF = table.Column<string>(type: "nchar(16)", fixedLength: true, maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CF);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitialContractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsurenceCoverage = table.Column<float>(type: "real", nullable: false),
                    MonthlyPayment = table.Column<float>(type: "real", nullable: false),
                    CustomerCF = table.Column<string>(type: "nchar(16)", nullable: true),
                    isurance_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineCapacity = table.Column<int>(type: "int", nullable: true),
                    CustomerAge = table.Column<int>(type: "int", nullable: true),
                    CoveragePercentage = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Insurance_Customer_CustomerCF",
                        column: x => x.CustomerCF,
                        principalTable: "Customer",
                        principalColumn: "CF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CustomerCF",
                table: "Insurance",
                column: "CustomerCF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

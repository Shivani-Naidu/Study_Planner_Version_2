using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG6212_POE.Migrations.TimeManagement
{
    public partial class semester : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SemesterWeeks = table.Column<int>(type: "int", nullable: false),
                    SemesterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SemesterName",
                table: "Semester",
                column: "SemesterName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semester_Username",
                table: "Semester",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Semester");
        }
    }
}

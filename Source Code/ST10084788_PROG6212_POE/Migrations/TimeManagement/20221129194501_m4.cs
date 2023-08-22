using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG6212_POE.Migrations.TimeManagement
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudySession",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursStudied = table.Column<int>(type: "int", nullable: false),
                    StudyWeek = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudySession", x => x.StudyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudySession");
        }
    }
}

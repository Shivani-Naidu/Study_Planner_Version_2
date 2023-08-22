using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG6212_POE.Migrations.TimeManagement
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Semester_SemesterName",
                table: "Semester");

            migrationBuilder.DropIndex(
                name: "IX_Semester_Username",
                table: "Semester");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Semester",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Semester",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}

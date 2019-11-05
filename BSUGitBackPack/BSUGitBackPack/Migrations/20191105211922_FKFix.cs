using Microsoft.EntityFrameworkCore.Migrations;

namespace BSUGitBackPack.Migrations
{
    public partial class FKFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_ClassForeignKey",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassForeignKey",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassForeignKey",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "ClassFK",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassFK",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "ClassForeignKey",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassForeignKey",
                table: "Student",
                column: "ClassForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_ClassForeignKey",
                table: "Student",
                column: "ClassForeignKey",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

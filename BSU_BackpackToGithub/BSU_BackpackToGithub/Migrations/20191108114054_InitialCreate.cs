using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSU_BackpackToGithub.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prefix = table.Column<string>(maxLength: 5, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Semester = table.Column<string>(maxLength: 2, nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BSU_Username = table.Column<string>(maxLength: 16, nullable: false),
                    GitHub_Username = table.Column<string>(maxLength: 39, nullable: false),
                    First_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Repo = table.Column<string>(maxLength: 78, nullable: false),
                    ClassFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

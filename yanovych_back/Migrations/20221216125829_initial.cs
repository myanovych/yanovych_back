using Microsoft.EntityFrameworkCore.Migrations;

namespace yanovych_back.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mark = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attendance = table.Column<double>(type: "float", nullable: false),
                    ExamMark = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LabList",
                columns: new[] { "Id", "Date", "Mark", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "2022-10-01", 7.0, 3, "Evaluated", "Lab1" },
                    { 2, "2022-10-10", 0.0, 2, "Submitted", "Lab2" }
                });

            migrationBuilder.InsertData(
                table: "StudentList",
                columns: new[] { "Id", "Attendance", "ExamMark" },
                values: new object[,]
                {
                    { 1, 16.0, 48.0 },
                    { 2, 12.0, 42.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabList");

            migrationBuilder.DropTable(
                name: "StudentList");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace yanovych_back.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "LabList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "LabList",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudentID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "LabList",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudentID",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "LabList");
        }
    }
}

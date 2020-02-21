using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPDotNetCoreCRUD.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Employees",
                newName: "OfficeLocation");

            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "nvarchar(10)",
                table: "Employees",
                newName: "EmpCode");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "OfficeLocation",
                table: "Employees",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "nvarchar(250)");

            migrationBuilder.RenameColumn(
                name: "EmpCode",
                table: "Employees",
                newName: "nvarchar(10)");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPDotNetCoreCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", nullable: false),
                    nvarchar10 = table.Column<string>(name: "nvarchar(10)", nullable: true),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

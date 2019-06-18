using Microsoft.EntityFrameworkCore.Migrations;

namespace QAwebApp.Migrations
{
    public partial class ManagerSid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerSid",
                table: "Forms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerSid",
                table: "Forms");
        }
    }
}

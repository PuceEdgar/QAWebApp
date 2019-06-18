using Microsoft.EntityFrameworkCore.Migrations;

namespace QAwebApp.Migrations
{
    public partial class CreatorFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Test",
                table: "Forms",
                newName: "Creator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "Forms",
                newName: "Test");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QAwebApp.Migrations
{
    public partial class DatetimeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AssessmentPeriod",
                table: "Forms",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AssessmentPeriod",
                table: "Forms",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

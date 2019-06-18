using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QAwebApp.Migrations
{
    public partial class SummaryComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAssessment",
                table: "Forms",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssessmentPeriod",
                table: "Forms",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SummaryGrComment",
                table: "Forms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SummaryUnitComment",
                table: "Forms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SummaryGrComment",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "SummaryUnitComment",
                table: "Forms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAssessment",
                table: "Forms",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssessmentPeriod",
                table: "Forms",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }
    }
}

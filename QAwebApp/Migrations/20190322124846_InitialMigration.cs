using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace QAwebApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitResponsibleModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sid = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitResponsibleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Division = table.Column<string>(nullable: true),
                    Bul1 = table.Column<string>(nullable: true),
                    Bul2 = table.Column<string>(nullable: true),
                    Bul3 = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AssessmentPeriod = table.Column<DateTime>(nullable: true),
                    UnitAssessor = table.Column<string>(nullable: true),
                    DateOfAssessment = table.Column<DateTime>(nullable: true),
                    BCMGrComment = table.Column<string>(nullable: true),
                    IRHGrComment = table.Column<string>(nullable: true),
                    NPAPGrComment = table.Column<string>(nullable: true),
                    ORSARTSAGrComment = table.Column<string>(nullable: true),
                    KRIGrComment = table.Column<string>(nullable: true),
                    ICCGrComment = table.Column<string>(nullable: true),
                    BCMUnitComment = table.Column<string>(nullable: true),
                    IRHUnitComment = table.Column<string>(nullable: true),
                    NPAPUnitComment = table.Column<string>(nullable: true),
                    ORSARTSAUnitComment = table.Column<string>(nullable: true),
                    KRIUnitComment = table.Column<string>(nullable: true),
                    ICCUnitComment = table.Column<string>(nullable: true),
                    BCMScore = table.Column<int>(nullable: false),
                    IRHScore = table.Column<int>(nullable: false),
                    NPAPScore = table.Column<string>(nullable: true),
                    ORSARTSAScore = table.Column<string>(nullable: true),
                    KRIScore = table.Column<int>(nullable: false),
                    ICCScore = table.Column<int>(nullable: false),
                    UnitResponsibleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_UnitResponsibleModel_UnitResponsibleId",
                        column: x => x.UnitResponsibleId,
                        principalTable: "UnitResponsibleModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_UnitResponsibleId",
                table: "Forms",
                column: "UnitResponsibleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "UnitResponsibleModel");
        }
    }
}

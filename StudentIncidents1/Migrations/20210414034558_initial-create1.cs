using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentIncidents1.Migrations
{
    public partial class initialcreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Student_StudentID",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Incident_StudentID",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Incident");

            migrationBuilder.CreateTable(
                name: "StudentIncident",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentIncident", x => new { x.StudentId, x.IncidentId });
                    table.ForeignKey(
                        name: "FK_StudentIncident_Incident_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incident",
                        principalColumn: "IncidentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentIncident_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentIncident_IncidentId",
                table: "StudentIncident",
                column: "IncidentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentIncident");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Incident",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incident_StudentID",
                table: "Incident",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Student_StudentID",
                table: "Incident",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

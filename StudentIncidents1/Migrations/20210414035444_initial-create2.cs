using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentIncidents1.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentDate",
                table: "Incident");

            migrationBuilder.AddColumn<DateTime>(
                name: "IncidentDate",
                table: "StudentIncident",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentDate",
                table: "StudentIncident");

            migrationBuilder.AddColumn<DateTime>(
                name: "IncidentDate",
                table: "Incident",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

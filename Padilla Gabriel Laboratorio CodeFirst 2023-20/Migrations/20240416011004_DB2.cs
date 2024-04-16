using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Migrations
{
    /// <inheritdoc />
    public partial class DB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudianteModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecintoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecintoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacunaModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Procedencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunaModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registro_VacModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteId = table.Column<int>(type: "int", nullable: false),
                    VacunaId = table.Column<int>(type: "int", nullable: false),
                    FechaVacunacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecintoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro_VacModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registro_VacModel_EstudianteModel_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "EstudianteModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_VacModel_RecintoModel_RecintoId",
                        column: x => x.RecintoId,
                        principalTable: "RecintoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_VacModel_VacunaModel_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "VacunaModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registro_VacModel_EstudianteId",
                table: "Registro_VacModel",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_VacModel_RecintoId",
                table: "Registro_VacModel",
                column: "RecintoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_VacModel_VacunaId",
                table: "Registro_VacModel",
                column: "VacunaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro_VacModel");

            migrationBuilder.DropTable(
                name: "EstudianteModel");

            migrationBuilder.DropTable(
                name: "RecintoModel");

            migrationBuilder.DropTable(
                name: "VacunaModel");
        }
    }
}

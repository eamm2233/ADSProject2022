using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSProject.Migrations
{
    public partial class RelacionAsignacionGrupos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsignacionGrupos",
                columns: table => new
                {
                    idAsigacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idGrupo = table.Column<int>(type: "int", nullable: false),
                    idEstudiante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionGrupos", x => x.idAsigacion);
                    table.ForeignKey(
                        name: "FK_AsignacionGrupos_Estudiantes_idEstudiante",
                        column: x => x.idEstudiante,
                        principalTable: "Estudiantes",
                        principalColumn: "idEstudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionGrupos_Grupos_idGrupo",
                        column: x => x.idGrupo,
                        principalTable: "Grupos",
                        principalColumn: "idGrupo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionGrupos_idEstudiante",
                table: "AsignacionGrupos",
                column: "idEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionGrupos_idGrupo",
                table: "AsignacionGrupos",
                column: "idGrupo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionGrupos");
        }
    }
}

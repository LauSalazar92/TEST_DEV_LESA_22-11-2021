using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonasFisicasPrueba.Data.Migrations
{
    public partial class tablasdesesion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_PersonasFisicas",
                columns: table => new
                {
                    IdPersonaFisica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    ApellidoPaterno = table.Column<string>(maxLength: 50, nullable: true),
                    ApellidoMaterno = table.Column<string>(maxLength: 50, nullable: true),
                    RFC = table.Column<string>(maxLength: 13, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: true),
                    UsuarioAgrega = table.Column<int>(nullable: true),
                    Activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_PersonasFisicas", x => x.IdPersonaFisica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_PersonasFisicas");
        }
    }
}

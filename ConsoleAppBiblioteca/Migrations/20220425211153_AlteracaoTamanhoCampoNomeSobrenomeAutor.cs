using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppBiblioteca.Migrations
{
    public partial class AlteracaoTamanhoCampoNomeSobrenomeAutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Autores",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Autores",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Autores",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Autores",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}

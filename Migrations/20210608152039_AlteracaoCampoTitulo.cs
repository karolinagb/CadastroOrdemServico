using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroOrdemServico.Migrations
{
    public partial class AlteracaoCampoTitulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Título",
                table: "OrdensServico",
                newName: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "OrdensServico",
                newName: "Título");
        }
    }
}

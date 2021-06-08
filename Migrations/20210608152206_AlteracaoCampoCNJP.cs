using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroOrdemServico.Migrations
{
    public partial class AlteracaoCampoCNJP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CPJCliente",
                table: "OrdensServico",
                newName: "CNPJCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJCliente",
                table: "OrdensServico",
                newName: "CPJCliente");
        }
    }
}

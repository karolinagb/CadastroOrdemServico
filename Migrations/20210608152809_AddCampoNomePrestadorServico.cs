using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroOrdemServico.Migrations
{
    public partial class AddCampoNomePrestadorServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomePrestadorServico",
                table: "OrdensServico",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomePrestadorServico",
                table: "OrdensServico");
        }
    }
}

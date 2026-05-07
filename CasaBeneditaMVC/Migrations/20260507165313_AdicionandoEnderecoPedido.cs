using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoEnderecoPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Pedidos");
        }
    }
}

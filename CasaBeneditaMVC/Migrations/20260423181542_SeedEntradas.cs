using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedEntradas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nome" },
                values: new object[,]
                {
                    { 1, "Entradas" },
                    { 2, "Pratos Principais" },
                    { 3, "Bebidas" },
                    { 4, "Sobremesas" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Disponivel", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, 1, "Entrada leve com pão e tomate", true, "Entradas/Bruschetta.png", "Bruschetta Benedita", 24.90m },
                    { 2, 1, "Finas fatias de carne", true, "Entradas/Carpaccio.png", "Carpaccio Especial da Casa", 29.90m },
                    { 3, 1, "Batatas crocantes", true, "Entradas/Batata.png", "Batata Rústica da Dona Benedita", 19.90m },
                    { 4, 1, "Bolinho crocante", true, "Entradas/Bolinho.png", "Bolinho Dourado da Vovó", 22.90m },
                    { 5, 1, "Petisco especial", true, "Entradas/Dadinhos.png", "Dadinhos Crocantes da Casa", 21.90m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1);
        }
    }
}

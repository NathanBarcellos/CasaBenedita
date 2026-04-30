using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class ProdutosCompletos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Disponivel", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 11, 3, "Lata 350ml", true, "Bebidas/refri_latas.jpg", "Refrigerante", 6.00m },
                    { 12, 3, "Suco de frutas frescas", true, "Bebidas/Suco.png", "Suco Natural", 9.90m },
                    { 13, 3, "Garrafa 330ml", true, "Bebidas/Cervejas.png", "Cerveja Long Neck", 14.00m },
                    { 14, 3, "Garrafa 500ml", true, "Bebidas/Agua.png", "Água Mineral", 4.00m },
                    { 15, 3, "Produção especial da casa", true, "Bebidas/Cervejas.png", "Cerveja Artesanal", 14.00m },
                    { 16, 4, "Pudim tradicional", true, "Sobremesas/Pudim.png", "Pudim", 12.00m },
                    { 17, 4, "Brownie de chocolate", true, "Sobremesas/Brownie.png", "Brownie", 18.90m },
                    { 18, 4, "Mousse cremoso", true, "Sobremesas/Mousse.png", "Mousse de Chocolate", 16.90m },
                    { 19, 4, "Sobremesa especial", true, "Sobremesas/DoceTentacao.png", "Doce Tentação", 17.90m },
                    { 20, 4, "Chocolate intenso", true, "Sobremesas/DeliciaChocolate.png", "Delícia de Chocolate", 19.90m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 20);
        }
    }
}

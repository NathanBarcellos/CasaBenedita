using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class FinalCompleto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Disponivel", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 6, 2, "Carne grelhada especial", true, "Pratos/picanha.png", "Picanha da Dona Benedita", 64.90m },
                    { 7, 2, "Costela suculenta", true, "Pratos/Costela.png", "Costela da Casa ao Molho Barbecue", 61.90m },
                    { 8, 2, "Filé com molho especial", true, "Pratos/FileMignon.png", "Filé Mignon ao Molho da Vovó", 69.90m },
                    { 9, 2, "Carne na brasa", true, "Pratos/contra.png", "Contra Filé Especial na Brasa", 49.90m },
                    { 10, 2, "Lombo assado", true, "Pratos/Lombo.png", "Lombo Suíno Assado da Fazenda", 44.90m },
                    { 11, 4, "Sobremesa da casa", true, "Sobremesas/Pudim.png", "Pudim Cremoso da Dona Benedita", 12.00m },
                    { 12, 4, "Brownie quente", true, "Sobremesas/Brownie.png", "Brownie Quentinho da Casa", 18.90m },
                    { 13, 4, "Mousse cremoso", true, "Sobremesas/Mousse.jpg", "Mousse de Chocolate Especial", 14.90m },
                    { 14, 4, "Sobremesa com frutas", true, "Sobremesas/DoceTentacao.png", "Doce Tentação de Frutas Vermelhas", 19.90m },
                    { 15, 4, "Chocolate especial", true, "Sobremesas/DeliciaChocolate.png", "Delícia de Chocolate com Coração Quente", 22.90m },
                    { 16, 3, "Lata 350ml", true, "Bebidas/refri_latas.jpg", "Refrigerante Gelado", 6.00m },
                    { 17, 3, "Suco natural", true, "Bebidas/Suco.png", "Suco Natural da Casa", 9.90m },
                    { 18, 3, "Água sem gás", true, "Bebidas/Agua.png", "Água Mineral", 4.00m },
                    { 19, 3, "Cerveja gelada", true, "Bebidas/Cervejas.png", "Cerveja Long Neck", 8.00m },
                    { 20, 3, "Cerveja especial", true, "Bebidas/Cervejas.png", "Cerveja Artesanal da Casa", 14.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 10);

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

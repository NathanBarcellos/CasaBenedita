using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedMesas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mesas",
                columns: new[] { "MesaId", "Capacidade", "Disponivel", "NumeroMesa" },
                values: new object[,]
                {
                    { 1, 4, true, 1 },
                    { 2, 4, true, 2 },
                    { 3, 4, true, 3 },
                    { 4, 4, true, 4 },
                    { 5, 4, true, 5 },
                    { 6, 4, true, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "MesaId",
                keyValue: 6);
        }
    }
}

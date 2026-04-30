using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaBeneditaMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddEhAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EhAdmin",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EhAdmin",
                table: "Usuarios");
        }
    }
}

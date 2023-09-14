using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGame.Migrations
{
    /// <inheritdoc />
    public partial class status_table_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Verb",
                table: "Status",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Verb",
                table: "Status");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGame.Migrations
{
    /// <inheritdoc />
    public partial class pokeapi_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Accuracy",
                table: "Attacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DamageClass",
                table: "Attacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Attacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "Attacks");

            migrationBuilder.DropColumn(
                name: "DamageClass",
                table: "Attacks");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Attacks");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatalhaDePokemons.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RenomeiaColunasParaNomesSignificativos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Spd",
                table: "Pokemons",
                newName: "Velocidade");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Pokemons",
                newName: "Nivel");

            migrationBuilder.RenameColumn(
                name: "Hp",
                table: "Pokemons",
                newName: "PontosDeVida");

            migrationBuilder.RenameColumn(
                name: "Def",
                table: "Pokemons",
                newName: "Defesa");

            migrationBuilder.RenameColumn(
                name: "Atk",
                table: "Pokemons",
                newName: "Ataque");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProximoTurnoDoPokemonId",
                table: "Batalhas",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Velocidade",
                table: "Pokemons",
                newName: "Spd");

            migrationBuilder.RenameColumn(
                name: "PontosDeVida",
                table: "Pokemons",
                newName: "Hp");

            migrationBuilder.RenameColumn(
                name: "Nivel",
                table: "Pokemons",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "Defesa",
                table: "Pokemons",
                newName: "Def");

            migrationBuilder.RenameColumn(
                name: "Ataque",
                table: "Pokemons",
                newName: "Atk");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProximoTurnoDoPokemonId",
                table: "Batalhas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}

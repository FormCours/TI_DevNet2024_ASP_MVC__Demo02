using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo_ASPMVC_02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Vie = table.Column<int>(type: "int", nullable: false),
                    PreEvolutionNumero = table.Column<int>(type: "int", nullable: true),
                    Type1Id = table.Column<int>(type: "int", nullable: false),
                    Type2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonType_Type1Id",
                        column: x => x.Type1Id,
                        principalTable: "PokemonType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonType_Type2Id",
                        column: x => x.Type2Id,
                        principalTable: "PokemonType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokemon_Pokemon_PreEvolutionNumero",
                        column: x => x.PreEvolutionNumero,
                        principalTable: "Pokemon",
                        principalColumn: "Numero");
                });

            migrationBuilder.InsertData(
                table: "PokemonType",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "Plante" },
                    { 2, "Eau" },
                    { 3, "Feu" },
                    { 4, "Roche" },
                    { 5, "Normal" },
                    { 6, "Psy" }
                });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Numero", "Nom", "PreEvolutionNumero", "Type1Id", "Type2Id", "Vie" },
                values: new object[,]
                {
                    { 1, "Bulbizarre", null, 1, null, 100 },
                    { 4, "Carapuce", null, 2, null, 100 },
                    { 2, "Herbizarre", 1, 1, null, 150 },
                    { 3, "Florizarre", 2, 1, null, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PreEvolutionNumero",
                table: "Pokemon",
                column: "PreEvolutionNumero",
                unique: true,
                filter: "[PreEvolutionNumero] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Type1Id",
                table: "Pokemon",
                column: "Type1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Type2Id",
                table: "Pokemon",
                column: "Type2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokemonType");
        }
    }
}

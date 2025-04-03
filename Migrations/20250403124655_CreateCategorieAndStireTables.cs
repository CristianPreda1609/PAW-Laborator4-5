using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laborator4_5.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategorieAndStireTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stire",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    continut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stire", x => x.id);
                    table.ForeignKey(
                        name: "FK_Stire_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stire_CategorieId",
                table: "Stire",
                column: "CategorieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stire");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}

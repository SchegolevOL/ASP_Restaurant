using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class initMeny : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menuNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menuPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menuNamePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuPositionId = table.Column<int>(type: "int", nullable: false),
                    MenuNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuNamePositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menuNamePositions_menuNames_MenuNameId",
                        column: x => x.MenuNameId,
                        principalTable: "menuNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_menuNamePositions_menuPositions_MenuPositionId",
                        column: x => x.MenuPositionId,
                        principalTable: "menuPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_menuNamePositions_MenuNameId",
                table: "menuNamePositions",
                column: "MenuNameId");

            migrationBuilder.CreateIndex(
                name: "IX_menuNamePositions_MenuPositionId",
                table: "menuNamePositions",
                column: "MenuPositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menuNamePositions");

            migrationBuilder.DropTable(
                name: "menuNames");

            migrationBuilder.DropTable(
                name: "menuPositions");
        }
    }
}

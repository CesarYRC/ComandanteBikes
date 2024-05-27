using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComandanteBikes.Migrations
{
    /// <inheritdoc />
    public partial class inventarioTienda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventarioTienda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeloInventario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ColorInventario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrecioInventario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TallaInventario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadTotal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioTienda", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventarioTienda");
        }
    }
}

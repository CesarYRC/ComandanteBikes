using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComandanteBikes.Migrations
{
    /// <inheritdoc />
    public partial class ventaTienda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VentaTienda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreClienteVenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CorreoClienteVenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TelefonoClienteVenta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaTienda", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaTienda");
        }
    }
}

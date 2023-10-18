using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProgramacionIVAPI.Migrations
{
    /// <inheritdoc />
    public partial class productos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, 23, "D1", "P1" },
                    { 2, 12, "D2", "P2" },
                    { 4, 76, "D3", "P3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 4);
        }
    }
}

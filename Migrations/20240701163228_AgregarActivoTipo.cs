using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConexionEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregarActivoTipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_MarcasProductos_MarcaProductoId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_TiposProductos_TipoProductoId",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_TipoProductoId",
                table: "Productos",
                newName: "IX_Productos_TipoProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_MarcaProductoId",
                table: "Productos",
                newName: "IX_Productos_MarcaProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_MarcasProductos_MarcaProductoId",
                table: "Productos",
                column: "MarcaProductoId",
                principalTable: "MarcasProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TiposProductos_TipoProductoId",
                table: "Productos",
                column: "TipoProductoId",
                principalTable: "TiposProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_MarcasProductos_MarcaProductoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TiposProductos_TipoProductoId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_TipoProductoId",
                table: "Producto",
                newName: "IX_Producto_TipoProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_MarcaProductoId",
                table: "Producto",
                newName: "IX_Producto_MarcaProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_MarcasProductos_MarcaProductoId",
                table: "Producto",
                column: "MarcaProductoId",
                principalTable: "MarcasProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_TiposProductos_TipoProductoId",
                table: "Producto",
                column: "TipoProductoId",
                principalTable: "TiposProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

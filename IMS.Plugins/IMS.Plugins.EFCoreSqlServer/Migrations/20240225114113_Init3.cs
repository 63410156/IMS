using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Plugins.EFCoreSqlServer.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutInventories_Inventories_InventoryId",
                table: "ProdutInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutInventories_Products_ProductId",
                table: "ProdutInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutInventories",
                table: "ProdutInventories");

            migrationBuilder.RenameTable(
                name: "ProdutInventories",
                newName: "ProductInventories");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutInventories_InventoryId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories",
                columns: new[] { "ProductId", "InventoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Inventories_InventoryId",
                table: "ProductInventories",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Inventories_InventoryId",
                table: "ProductInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories");

            migrationBuilder.RenameTable(
                name: "ProductInventories",
                newName: "ProdutInventories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_InventoryId",
                table: "ProdutInventories",
                newName: "IX_ProdutInventories_InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutInventories",
                table: "ProdutInventories",
                columns: new[] { "ProductId", "InventoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutInventories_Inventories_InventoryId",
                table: "ProdutInventories",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutInventories_Products_ProductId",
                table: "ProdutInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

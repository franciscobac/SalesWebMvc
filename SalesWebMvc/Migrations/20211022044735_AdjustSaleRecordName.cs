using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class AdjustSaleRecordName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecoed_Seller_SellerId",
                table: "SalesRecoed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecoed",
                table: "SalesRecoed");

            migrationBuilder.RenameTable(
                name: "SalesRecoed",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecoed_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalesRecoed");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecoed",
                newName: "IX_SalesRecoed_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecoed",
                table: "SalesRecoed",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecoed_Seller_SellerId",
                table: "SalesRecoed",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

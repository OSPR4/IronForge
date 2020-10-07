using Microsoft.EntityFrameworkCore.Migrations;

namespace IronForge.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "LongDescription",
                value: "This is the premier power bar in the Iron Forge arsenal; equipped with a stainless steel shaft and sleeves for a superior feel and unmatched oxidation resistance. Includes a zero-flex 200,000 PSI tensile strength shaft, quality bronze bushings, and 16.25” of loadable sleeve length.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "LongDescription",
                value: "KG Competition Plates are all a standard 450MM in diameter, with chrome-plated steel disc inserts and a 50.4MM collar opening for a firm, stable hold. The weight tolerance for each bumper is +/- 15 grams, and the average durometer rating of 94 ensures a minimal / dead bounce on the drop.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "LongDescription",
                value: "With more than 50 combinations of seat and back-rest positions to choose from, the Iron Forge Adjustable Bench can easily adapt to each individual athlete, improving the overall efficiency and productivity of any strength training facility. No matter your size, workout preferences, or available training space, this compact, 11-gauge steel bench provides the rare combination of sturdiness and maneuverability that few other adjustable weight benches even attempt to match. The Iron Forge Adjustable Bench includes six different seat settings and nine additional back rest positions, making it easily among the most versatile weight benches on the market.");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "LongDescription",
                value: "   This is the premier power bar in the Iron Forge arsenal; equipped with a stainless steel shaft and sleeves for a superior feel and unmatched oxidation resistance. Includes a zero-flex 200,000 PSI tensile strength shaft, quality bronze bushings, and 16.25” of loadable sleeve length.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "LongDescription",
                value: " KG Competition Plates are all a standard 450MM in diameter, with chrome-plated steel disc inserts and a 50.4MM collar opening for a firm, stable hold. The weight tolerance for each bumper is +/- 15 grams, and the average durometer rating of 94 ensures a minimal / dead bounce on the drop.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "LongDescription",
                value: "  With more than 50 combinations of seat and back-rest positions to choose from, the Iron Forge Adjustable Bench can easily adapt to each individual athlete, improving the overall efficiency and productivity of any strength training facility. No matter your size, workout preferences, or available training space, this compact, 11-gauge steel bench provides the rare combination of sturdiness and maneuverability that few other adjustable weight benches even attempt to match. The Iron Forge Adjustable Bench includes six different seat settings and nine additional back rest positions, making it easily among the most versatile weight benches on the market.");
        }
    }
}

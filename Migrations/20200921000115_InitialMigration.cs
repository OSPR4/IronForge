using Microsoft.EntityFrameworkCore.Migrations;

namespace IronForge.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Barbells" },
                    { 2, "Plates" },
                    { 3, "Benches" },
                    { 4, "Racks" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "~/Images/Olympic_Weightlifting_Bar.jpg", "~/Images/Olympic_Weightlifting_Bar.jpg", true, "Combining a stainless steel, 200,000 PSI tensile strength shaft with industrial hard chrome sleeves and quality needle bearings, this version of the Iron Forge Olympic Weightlifting Bar ranks among the best in the industry for feel, durability, and performance.", "OLYMPIC WEIGHTLIFTING BAR - STAINLESS STEEL", 450m, "OLYMPIC WEIGHTLIFTING BAR - STAINLESS STEEL" },
                    { 2, 1, "~/Images/Power_Bar.jpg", "~/Images/Power_Bar.jpg", true, "   This is the premier power bar in the Iron Forge arsenal; equipped with a stainless steel shaft and sleeves for a superior feel and unmatched oxidation resistance. Includes a zero-flex 200,000 PSI tensile strength shaft, quality bronze bushings, and 16.25” of loadable sleeve length.", "POWER BAR - STAINLESS STEEL", 350m, "POWER BAR - STAINLESS STEEL" },
                    { 3, 2, "~/Images/20KG_Competition_Plates.jpg", "~/Images/20KG_Competition_Plates.jpg", true, " KG Competition Plates are all a standard 450MM in diameter, with chrome-plated steel disc inserts and a 50.4MM collar opening for a firm, stable hold. The weight tolerance for each bumper is +/- 15 grams, and the average durometer rating of 94 ensures a minimal / dead bounce on the drop.", "20KG COMPETITION PLATES", 250m, "20KG COMPETITION PLATES" },
                    { 4, 3, "~/Images/Weight_Bench.jpg", "~/Images/Weight_Bench.jpg", true, "  With more than 50 combinations of seat and back-rest positions to choose from, the Iron Forge Adjustable Bench can easily adapt to each individual athlete, improving the overall efficiency and productivity of any strength training facility. No matter your size, workout preferences, or available training space, this compact, 11-gauge steel bench provides the rare combination of sturdiness and maneuverability that few other adjustable weight benches even attempt to match. The Iron Forge Adjustable Bench includes six different seat settings and nine additional back rest positions, making it easily among the most versatile weight benches on the market.", "ADJUSTABLE BENCH", 800m, "ADJUSTABLE BENCH" },
                    { 5, 4, "~/Images/Power_Rack.jpg", "~/Images/Power_Rack.jpg", true, "Iron Forge Power Rack is among the most versatile and customizable power racks in the industry. Each unit comes with standard  (6) 90” uprights, 5/8” bolts and fasteners, (2)  J-Cups, (2) pin/pipe safeties, (4) band pegs, (1) 43” single pull-up bar, and (8) plate storage posts for the back section of the unit. The laser-cut holes on each upright are spaced in the Westside pattern: 1” through bench and clean pull zone, 2” spacing above and below.", "POWER RACK", 1050m, "POWER RACK" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

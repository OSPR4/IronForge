using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IronForge.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Barbells" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Plates" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Benches" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, Name = "Racks" });


            //seed Products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "OLYMPIC WEIGHTLIFTING BAR - STAINLESS STEEL",
                Price = 450M,
                ShortDescription = "OLYMPIC WEIGHTLIFTING BAR - STAINLESS STEEL",
                LongDescription = "Combining a stainless steel, 200,000 PSI tensile strength shaft with industrial hard chrome sleeves and quality needle bearings, this version of the Iron Forge Olympic Weightlifting Bar ranks among the best in the industry for feel, durability, and performance.",
                CategoryId = 1,
                ImageUrl = "~/Images/Olympic_Weightlifting_Bar.jpg",
                InStock = true,
                ImageThumbnailUrl = "~/Images/Olympic_Weightlifting_Bar.jpg"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "POWER BAR - STAINLESS STEEL",
                Price = 350M,
                ShortDescription = "POWER BAR - STAINLESS STEEL",
                LongDescription = "This is the premier power bar in the Iron Forge arsenal; equipped with a stainless steel shaft and sleeves for a superior feel and unmatched oxidation resistance. Includes a zero-flex 200,000 PSI tensile strength shaft, quality bronze bushings, and 16.25” of loadable sleeve length.",
                CategoryId = 1,
                ImageUrl = "~/Images/Power_Bar.jpg",
                InStock = true,
                ImageThumbnailUrl = "~/Images/Power_Bar.jpg"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "20KG COMPETITION PLATES",
                Price = 250M,
                ShortDescription = "20KG COMPETITION PLATES",
                LongDescription = "KG Competition Plates are all a standard 450MM in diameter, with chrome-plated steel disc inserts and a 50.4MM collar opening for a firm, stable hold. The weight tolerance for each bumper is +/- 15 grams, and the average durometer rating of 94 ensures a minimal / dead bounce on the drop.",
                CategoryId = 2,
                ImageUrl = "~/Images/20KG_Competition_Plates.jpg",
                InStock = true,
                ImageThumbnailUrl = "~/Images/20KG_Competition_Plates.jpg"

            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "ADJUSTABLE BENCH",
                Price = 800M,
                ShortDescription = "ADJUSTABLE BENCH",
                LongDescription = "With more than 50 combinations of seat and back-rest positions to choose from, the Iron Forge Adjustable Bench can easily adapt to each individual athlete, improving the overall efficiency and productivity of any strength training facility. No matter your size, workout preferences, or availabl" +
                "e training space, this compact, 11-gauge steel bench provides the rare combination of sturdiness and maneuverability that few other adjustable weight benches even attempt to match. The Iron Forge Adjustable Bench includes six different seat settings and nine additional back rest positions, making it easily among the most versatile weight benches on the market.",
                CategoryId = 3,
                ImageUrl = "~/Images/Weight_Bench.jpg",
                InStock = true,
                ImageThumbnailUrl = "~/Images/Weight_Bench.jpg"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "POWER RACK",
                Price = 1050M,
                ShortDescription = "POWER RACK",
                LongDescription = "Iron Forge Power Rack is among the most versatile and customizable power racks in the industry. Each unit comes with standard  (6) 90” uprights, 5/8” bolts and fasteners, (2)  J-Cups, (2) pin/pipe safeties, (4) band pegs, (1) 43” single pull-up bar, and (8) plate storage posts for the back section of the unit. The laser-cut holes on each upright are spaced in the Westside pattern: 1” through bench and clean pull zone, 2” spacing above and below.",
                CategoryId = 4,
                ImageUrl = "~/Images/Power_Rack.jpg",
                InStock = true,
                ImageThumbnailUrl = "~/Images/Power_Rack.jpg"

            });
        }
    }
}

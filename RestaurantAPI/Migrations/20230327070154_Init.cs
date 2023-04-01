using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Nuts = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vegeterian = table.Column<bool>(type: "bit", nullable: false),
                    Spiciness = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basket_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Salads" },
                    { 2, "Soups" },
                    { 3, "Chicken-Dishes" },
                    { 4, "Beef-Dishes" },
                    { 5, "Seafood-Dishes" },
                    { 6, "Vegetable-Dishes" },
                    { 7, "Bits&Bites" },
                    { 8, "On-The-Side" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Nuts", "Price", "Spiciness", "Vegeterian" },
                values: new object[,]
                {
                    { 1, 1, "https://course-jsbasic.javascript.ru/assets/products/laab_kai_chicken_salad.png", "Laab kai chicken salad", true, 10.0, 2, false },
                    { 2, 1, "https://course-jsbasic.javascript.ru/assets/products/som_tam_papaya_salad.png", "Som tam papaya salad", false, 9.5, 0, true },
                    { 3, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_yam.png", "Tom yam kai", false, 7.0, 3, false },
                    { 4, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_kha.png", "Tom kha kai", false, 7.0, 3, false },
                    { 5, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_kha.png", "Tom kha koong", false, 8.0, 2, false },
                    { 6, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_yam.png", "Tom yam koong", false, 8.0, 4, false },
                    { 7, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_yam.png", "Tom yam vegetarian", false, 7.0, 1, true },
                    { 8, 2, "https://course-jsbasic.javascript.ru/assets/products/tom_kha.png", "Tom kha vegetarian", false, 7.0, 1, true },
                    { 9, 3, "https://course-jsbasic.javascript.ru/assets/products/sweet_n_sour.png", "Sweet 'n sour chicken", true, 14.0, 2, false },
                    { 10, 3, "https://course-jsbasic.javascript.ru/assets/products/chicken_cashew.png", "Chicken cashew", true, 14.0, 1, false },
                    { 11, 3, "https://course-jsbasic.javascript.ru/assets/products/kai_see_ew.png", "Kai see ew", false, 14.0, 4, false },
                    { 12, 4, "https://course-jsbasic.javascript.ru/assets/products/beef_massaman.png", "Beef massaman", false, 14.5, 2, false },
                    { 13, 5, "https://course-jsbasic.javascript.ru/assets/products/chu_chee.png", "Seafood chu chee", false, 16.0, 2, false },
                    { 14, 5, "https://course-jsbasic.javascript.ru/assets/products/red_curry.png", "Penang shrimp", true, 16.0, 4, false },
                    { 15, 6, "https://course-jsbasic.javascript.ru/assets/products/green_curry.png", "Green curry veggies", true, 12.5, 0, true },
                    { 16, 6, "https://course-jsbasic.javascript.ru/assets/products/tofu_cashew.png", "Tofu cashew", true, 12.5, 0, true },
                    { 17, 6, "https://course-jsbasic.javascript.ru/assets/products/red_curry_vega.png", "Red curry veggies", false, 12.5, 4, true },
                    { 18, 6, "https://course-jsbasic.javascript.ru/assets/products/krapau_vega.png", "Krapau tofu", false, 12.5, 0, true },
                    { 19, 7, "https://course-jsbasic.javascript.ru/assets/products/kroepoek.png", "Prawn crackers", false, 2.5, 1, false },
                    { 20, 7, "https://course-jsbasic.javascript.ru/assets/products/fish_cakes.png", "Fish cakes", false, 6.5, 1, false },
                    { 21, 7, "https://course-jsbasic.javascript.ru/assets/products/sate.png", "Chicken satay", false, 6.5, 1, false },
                    { 22, 7, "https://course-jsbasic.javascript.ru/assets/products/satesaus.png", "Satay sauce", false, 1.5, 2, false },
                    { 23, 7, "https://course-jsbasic.javascript.ru/assets/products/koong_hom_pha.png", "Shrimp springrolls", false, 6.5, 3, false },
                    { 24, 7, "https://course-jsbasic.javascript.ru/assets/products/mini_vega_springrolls.png", "Mini vegetarian spring rolls", false, 6.5, 2, false },
                    { 25, 7, "https://course-jsbasic.javascript.ru/assets/products/chicken_loempias.png", "Chicken springrolls", false, 6.5, 2, false },
                    { 26, 8, "https://course-jsbasic.javascript.ru/assets/products/fried_rice.png", "Thai fried rice", false, 7.5, 2, false },
                    { 27, 8, "https://course-jsbasic.javascript.ru/assets/products/kroepoek.png", "Fresh prawn crackers", false, 2.5, 1, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ProductId",
                table: "Basket",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Phones.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addedNewPhones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Samsung earpuds");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ListPrice","Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 7, "OnePlus", 1, "Flagship phone with Snapdragon 888, Hasselblad camera, and 120Hz AMOLED display.", 899.0, 850.0, 750.0, 800.0, "OnePlus 9 Pro" },
                    { 8, "Xiaomi", 1, "High-performance phone with Snapdragon 888, 108MP camera, and 55W fast charging.", 749.0, 700.0, 600.0, 650.0, "Xiaomi Mi 11" },
                    { 9, "Sony", 1, "Premium phone with 4K OLED display, Snapdragon 888, and advanced camera features.", 1299.0, 1250.0, 1150.0, 1200.0, "Sony Xperia 1 III" },
                    { 10, "Motorola", 1, "Mid-range phone with Snapdragon 778G, 144Hz display, and 108MP camera.", 499.0, 450.0, 350.0, 400.0, "Motorola Edge 20" },
                    { 11, "Asus", 1, "Gaming phone with Snapdragon 888, 144Hz AMOLED display, and massive 6000mAh battery.", 999.0, 950.0, 850.0, 900.0, "Asus ROG Phone 5" },
                    { 12, "LG", 1, "Stylish phone with Snapdragon 845, dual-screen compatibility, and 48MP camera.", 599.0, 550.0, 450.0, 500.0, "LG Velvet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Samsung Guru");
        }
    }
}

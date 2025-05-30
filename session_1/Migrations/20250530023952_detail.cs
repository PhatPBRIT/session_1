using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session_1.Migrations
{
    /// <inheritdoc />
    public partial class detail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Name product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection. ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Vietnamese product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "UK product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "India product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Russian product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "France product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Name product ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Vietnamese product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "UK product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "India product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Russian product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "France product");
        }
    }
}

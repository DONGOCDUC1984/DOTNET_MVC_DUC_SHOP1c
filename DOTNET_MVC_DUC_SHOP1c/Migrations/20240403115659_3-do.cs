using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNET_MVC_DUC_SHOP1c.Migrations
{
    public partial class _3do : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DistrictId", "ImageUrl", "Name", "Price", "ProvinceCityId" },
                values: new object[,]
                {
                    { 2, 1, "Good.Made in Sweden", 2, "\\images\\product\\Apple2.jpg", "Apple 2", 8.0, 1 },
                    { 20, 1, "Good.Made in Norway", 10, "\\images\\product\\Grapes2.jpg", "Grapes 2", 7.0, 3 },
                    { 19, 1, "Good.Made in Finland", 9, "\\images\\product\\Grapes1.jpg", "Grapes 1", 3.0, 3 },
                    { 18, 1, "High quality, made in Sweden", 8, "\\images\\product\\Grapefruit.jpg", "Grapefruit", 4.0, 3 },
                    { 17, 1, "Made in Poland", 7, "\\images\\product\\Ginger.jpg", "Ginger", 1.0, 3 },
                    { 16, 2, "Made in Vietnam", 6, "\\images\\product\\French loaf.jpg", "French loaf", 5.0, 2 },
                    { 15, 1, "Made in Laos", 5, "\\images\\product\\Cucumber2.jpg", "Cucumber 2", 4.0, 2 },
                    { 14, 1, "Made in Germany", 4, "\\images\\product\\Cucumber1.jpg", "Cucumber 1", 2.0, 2 },
                    { 13, 2, "Made in Finland", 3, "\\images\\product\\Croissant.jpg", "Croissant", 3.0, 1 },
                    { 21, 3, "Good.Made in Poland", 1, "\\images\\product\\Soy Milk.jpg", "Soy Milk", 5.0, 1 },
                    { 12, 3, "With sugar.Made in Germany", 2, "\\images\\product\\Cow Milk.jpg", "Cow Milk", 8.0, 1 },
                    { 10, 1, "High quality, made in Denmark", 10, "\\images\\product\\Cauliflower.jpg", "Cauliflower", 11.0, 3 },
                    { 9, 1, "Delicious, made in Britain", 9, "\\images\\product\\Carrot.jpg", "Carrot", 2.0, 3 },
                    { 8, 1, "High quality, made in Germany", 8, "\\images\\product\\Cabbage.jpg", "Cabbage", 9.0, 3 },
                    { 7, 1, "Made in Vietnam", 7, "\\images\\product\\Broccoli.jpg", "Broccoli", 6.0, 3 },
                    { 6, 2, "Sweet.Made in Germany", 6, "\\images\\product\\Bread1.jpg", "Bread 1", 4.0, 2 },
                    { 5, 1, "Made in Vietnam", 5, "\\images\\product\\Bell Pepper.jpg", "Bell Pepper", 5.0, 2 },
                    { 4, 1, "Sweet.Made in Vietnam", 4, "\\images\\product\\Banana.jpg", "Banana", 2.0, 2 },
                    { 3, 1, "Sweet.Made in Vietnam", 3, "\\images\\product\\Apricot.jpg", "Apricot", 6.0, 1 },
                    { 11, 1, "High quality.Made in Denmark", 1, "\\images\\product\\Cherry.jpg", "Cherry", 12.0, 1 },
                    { 22, 2, "Good.Made in Norway", 2, "\\images\\product\\Tommaso.jpg", "Tommaso", 2.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNET_MVC_DUC_SHOP1c.Migrations
{
    public partial class _2do : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DistrictId", "ImageUrl", "Name", "Price", "ProvinceCityId" },
                values: new object[] { 1, 1, "Sweet.Made in Germany", 1, "\\images\\product\\Apple1.jpg", "Apple 1", 3.0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

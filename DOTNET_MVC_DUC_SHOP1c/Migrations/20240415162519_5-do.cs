using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNET_MVC_DUC_SHOP1c.Migrations
{
    public partial class _5do : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnualProfits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyProfit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualProfits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AnnualProfits",
                columns: new[] { "Id", "Month", "MonthlyProfit" },
                values: new object[,]
                {
                    { 1, "January", 500.0 },
                    { 2, "February", 300.0 },
                    { 3, "March", 600.0 },
                    { 4, "April", 800.0 },
                    { 5, "May", 700.0 },
                    { 6, "June", 200.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnualProfits");
        }
    }
}

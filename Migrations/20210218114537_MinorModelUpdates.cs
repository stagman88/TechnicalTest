using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2021.Migrations
{
    public partial class MinorModelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitsSold = table.Column<int>(type: "int", nullable: false),
                    ProductSoldId = table.Column<int>(type: "int", nullable: true),
                    ClientSoldToId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Clients_ClientSoldToId",
                        column: x => x.ClientSoldToId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductSoldId",
                        column: x => x.ProductSoldId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientSoldToId",
                table: "Sales",
                column: "ClientSoldToId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductSoldId",
                table: "Sales",
                column: "ProductSoldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Clients");
        }
    }
}

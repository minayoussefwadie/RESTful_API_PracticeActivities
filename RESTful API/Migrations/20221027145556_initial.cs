using Microsoft.EntityFrameworkCore.Migrations;

namespace RESTful_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true),
                    CatID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CatID",
                        column: x => x.CatID,
                        principalTable: "Categories",
                        principalColumn: "CatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatID", "Name" },
                values: new object[] { 1, "Headphones" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatID", "Name" },
                values: new object[] { 2, "Mobile Phones" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CatID", "ImgURL", "Name", "Price", "Quantity" },
                values: new object[] { 1, 1, "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg", "Samsung Galaxy Buds2 Pro Bluetooth Earbuds", 1f, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CatID", "ImgURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, 1, "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg", "Huawei Freebuds Pro 2, Dual Speaker True Sound, Pure Voice, Silver", 2f, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CatID", "ImgURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, 2, "https://m.media-amazon.com/images/I/91GtFUXNGTL._AC_SX679_.jpg", "SAMSUNG Dual Sim 12GB RAM 256GB 5G Galaxy S22 Ultra - Phantom Black", 3f, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatID",
                table: "Products",
                column: "CatID");
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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductImagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    Bottom = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 28, 54, 309, DateTimeKind.Local).AddTicks(4223), new Guid("a70a1a32-ce0c-4a5e-8192-9a8091e3fa46") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 28, 54, 310, DateTimeKind.Local).AddTicks(5878), new Guid("3649d994-2617-4046-8506-51debf79652b") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 28, 54, 310, DateTimeKind.Local).AddTicks(5894), new Guid("c46b852c-dc1f-40f3-8ce3-f2a668e77afd") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 28, 54, 310, DateTimeKind.Local).AddTicks(5896), new Guid("43d51eea-4afb-43b5-a42b-cc68fc66a611") });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 311, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 28, 54, 313, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 5, 16, 46, 29, 87, DateTimeKind.Local).AddTicks(4427), new Guid("a923f072-5e59-423d-a34a-68b44e9ed3fc") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 5, 16, 46, 29, 88, DateTimeKind.Local).AddTicks(8339), new Guid("9482a0f5-9b15-4838-ba16-09e8d4c38806") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 5, 16, 46, 29, 88, DateTimeKind.Local).AddTicks(8358), new Guid("95294e09-1baa-4213-8779-84ca1367fe94") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 5, 16, 46, 29, 88, DateTimeKind.Local).AddTicks(8361), new Guid("b675bee1-c69a-4082-9426-1dcfc838d40e") });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 89, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 90, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 92, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 92, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 92, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 92, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 11, 5, 16, 46, 29, 93, DateTimeKind.Local).AddTicks(15));
        }
    }
}

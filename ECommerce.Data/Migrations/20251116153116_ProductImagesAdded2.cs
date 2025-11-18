using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductImagesAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 31, 15, 529, DateTimeKind.Local).AddTicks(8589), new Guid("274435be-5a4e-49f9-92c7-7f132a67ef8a") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 31, 15, 530, DateTimeKind.Local).AddTicks(9878), new Guid("d02930bc-271e-45ff-86a2-cf39ef5c7e30") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 31, 15, 530, DateTimeKind.Local).AddTicks(9898), new Guid("df08910a-8e9e-4aa3-b3c9-1b7cf81a82b7") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 31, 15, 530, DateTimeKind.Local).AddTicks(9910), new Guid("0965ab76-bafe-4441-9832-6eee4140422b") });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 531, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 532, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 11, 16, 18, 31, 15, 533, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}

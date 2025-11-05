using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class ordertables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductId",
                table: "OrderLines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 24, 50, 449, DateTimeKind.Local).AddTicks(4707), new Guid("8a4bc66a-6d60-439e-b7f9-1e851bf9e7b9") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 24, 50, 471, DateTimeKind.Local).AddTicks(1418), new Guid("78751fae-867a-46d2-a64f-be1fe4cdef2e") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 24, 50, 471, DateTimeKind.Local).AddTicks(1436), new Guid("41470a48-7168-47b9-b6cc-78d22ab8eeea") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 24, 50, 471, DateTimeKind.Local).AddTicks(1438), new Guid("cc9e6814-0aa1-40e0-befe-c302d43b16ff") });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 472, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 11, 4, 15, 24, 50, 474, DateTimeKind.Local).AddTicks(4461));
        }
    }
}

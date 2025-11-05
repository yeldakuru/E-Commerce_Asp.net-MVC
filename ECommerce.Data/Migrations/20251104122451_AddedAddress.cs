using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpenAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsBillingAddress = table.Column<bool>(type: "bit", nullable: false),
                    IsDeliveryAddress = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AppUserId",
                table: "Addresses",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 19, 22, 48, 15, 596, DateTimeKind.Local).AddTicks(45), new Guid("67f1bc16-3be7-435f-a07c-e02359067ca2") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1025), new Guid("0dff9903-fee7-4c5f-9999-dc6407734661") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1044), new Guid("2c83fb31-1832-42a8-a488-578719336032") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1046), new Guid("30dfec20-25db-41d4-9d73-85e9808c805c") });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6781));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(750)",
                oldMaxLength: 750,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Brands",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AppUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AppUsers",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AppUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 19, 22, 48, 15, 596, DateTimeKind.Local).AddTicks(45), new Guid("67f1bc16-3be7-435f-a07c-e02359067ca2") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "IsAdmin", "Name", "Password", "Phone", "Surname", "UserGuid", "UserName" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1025), "yelda@example.com", true, false, "Yelda", "123456", null, "Kuru", new Guid("0dff9903-fee7-4c5f-9999-dc6407734661"), "yelda" },
                    { 3, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1044), "ahmet@example.com", true, false, "Ahmet", "654321", null, "Demir", new Guid("2c83fb31-1832-42a8-a488-578719336032"), "ahmet" },
                    { 4, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(1046), "elif@example.com", true, false, "Elif", "123123", null, "Yılmaz", new Guid("30dfec20-25db-41d4-9d73-85e9808c805c"), "elif" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "Logo", "Name", "OrderNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8066), null, false, null, "Asus", 0 },
                    { 2, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8379), null, false, null, "HP", 0 },
                    { 3, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8381), null, false, null, "Sony", 0 },
                    { 4, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8382), null, false, null, "MSI", 0 },
                    { 5, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8382), null, false, null, "Logitech", 0 },
                    { 6, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8383), null, false, null, "Apple", 0 },
                    { 7, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8383), null, false, null, "Samsung", 0 },
                    { 8, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8384), null, false, null, "Dell", 0 },
                    { 9, new DateTime(2025, 10, 19, 22, 48, 15, 597, DateTimeKind.Local).AddTicks(8385), null, false, null, "Canon", 0 }
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "Image", "IsActive", "IsTopMenu", "Name", "OrderNo", "ParentId" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2707), null, null, true, false, "Monitör", 3, 1 },
                    { 4, new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2708), null, null, true, false, "Klavye", 4, 2 },
                    { 5, new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2709), null, null, true, false, "Konsol", 5, 1 },
                    { 6, new DateTime(2025, 10, 19, 22, 48, 15, 598, DateTimeKind.Local).AddTicks(2710), null, null, true, false, "Aksesuar", 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "Image", "IsActive", "IsHome", "Name", "OrderNo", "Price", "ProductCode", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(5579), "15.6 inç Full HD, Ryzen 7 işlemci, 16 GB RAM, 512 GB SSD", null, true, true, "Asus TUF Gaming Laptop", 1, 32999.90m, "ASUS-TUF-01", 25 },
                    { 2, 2, 2, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6728), "13.3 inç, Intel i5, 8 GB RAM, 256 GB SSD", null, true, false, "HP Pavilion Laptop", 2, 21499.50m, "HP-PAV-02", 18 },
                    { 3, 3, 5, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6732), "825 GB SSD, DualSense kumanda dahil", null, true, true, "Sony PlayStation 5", 3, 25999.00m, "SONY-PS5", 10 },
                    { 4, 4, 3, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6734), "27 inç, 165Hz, 1ms, kavisli oyun monitörü", null, true, false, "MSI Optix Monitör", 4, 8999.99m, "MSI-MON-04", 15 },
                    { 5, 5, 4, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6736), "RGB aydınlatmalı, suya dayanıklı, oyun klavyesi", null, true, false, "Logitech G213 Klavye", 5, 2499.90m, "LOGI-KLAV-05", 40 },
                    { 6, 6, 2, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6769), "13.3 inç Retina, M1 çip, 8 GB RAM, 256 GB SSD", null, true, true, "Apple MacBook Air", 6, 23999.00m, "APPLE-MBA-06", 12 },
                    { 7, 7, 1, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6772), "11 inç, Snapdragon 865+, 6 GB RAM, 128 GB depolama", null, true, false, "Samsung Galaxy Tab S7", 7, 10999.90m, "SAMSUNG-TAB-07", 20 },
                    { 8, 8, 2, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6773), "13.4 inç FHD+, Intel i7, 16 GB RAM, 512 GB SSD", null, true, true, "Dell XPS 13 Laptop", 8, 27999.50m, "DELL-XPS13-08", 14 },
                    { 9, 9, 1, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6775), "24.1 MP, 4K video, döndürülebilir ekran", null, true, false, "Canon EOS M50 Kamera", 9, 7499.99m, "CANON-EOSM50-09", 22 },
                    { 10, 3, 6, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6777), "Gürültü engelleme, Bluetooth 5.3, 30 saat pil", null, true, false, "Sony WH-1000XM5 Kulaklık", 10, 9999.90m, "SONY-WH1000XM5", 25 },
                    { 11, 1, 4, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6779), "RGB mekanik oyun klavyesi, dayanıklı tuş yapısı", null, true, false, "Asus ROG Klavye", 11, 3499.99m, "ASUS-ROG-KLAV", 30 },
                    { 12, 4, 6, new DateTime(2025, 10, 19, 22, 48, 15, 599, DateTimeKind.Local).AddTicks(6781), "7200 DPI, ergonomik tasarım, RGB ışıklandırma", null, true, false, "MSI Gaming Mouse", 12, 1599.50m, "MSI-MOUSE-12", 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(750)",
                maxLength: 750,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Contacts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Brands",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AppUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AppUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AppUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 10, 13, 16, 55, 1, 235, DateTimeKind.Local).AddTicks(9658), new Guid("2748d702-8aab-40d9-b2f6-06ff0887e4fa") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

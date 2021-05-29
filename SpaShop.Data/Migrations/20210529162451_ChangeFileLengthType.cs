using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7abd6a5f-7dc0-4fdb-b9c6-81c409ea25c3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54c2dc6c-9faa-4310-8025-84bd65466ed0", "AQAAAAEAACcQAAAAENrxOjHyukuo6YPjOAl1kXE20Im1IvVAL/Bb1uSSWCjKsAg2YCA1ao/O4bQ4rF8D8A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 29, 23, 24, 49, 973, DateTimeKind.Local).AddTicks(3907));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "302e758e-9720-4c1b-93f5-9e51d03c6684");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63519a63-2d72-442f-b9d2-3e1d21ebabf8", "AQAAAAEAACcQAAAAEPENkog0Dw3iXF5j4+5VokKeXIADOqywXbpmaeH8s5aRsw7gHwZ/ee31VSms7if9IQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 22, 5, 7, 168, DateTimeKind.Local).AddTicks(1328));
        }
    }
}

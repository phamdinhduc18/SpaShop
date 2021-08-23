using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaShop.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "IsDegault",
                table: "Languages",
                newName: "IsDefault");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "ProductTranslations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 23, 15, 24, 6, 984, DateTimeKind.Local).AddTicks(2053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 23, 14, 38, 39, 358, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "Languages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "CategoryTranslations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "IsDefault",
                table: "Languages",
                newName: "IsDegault");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "ProductTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 23, 14, 38, 39, 358, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 23, 15, 24, 6, 984, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "CategoryTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

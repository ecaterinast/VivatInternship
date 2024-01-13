using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivatInternship.Backend.Migrations
{
    /// <inheritdoc />
    public partial class FixingProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "PaymentInitiated",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "RegisterIP",
                table: "Users",
                newName: "Password");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "RegisterDateTime",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LoginDateTime",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Baskets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "RegisterIP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Baskets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PaymentInitiated",
                table: "Baskets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StoreId",
                table: "Baskets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserProfileId",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

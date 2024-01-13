using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivatInternship.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Baskets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Baskets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedTimestamp",
                table: "Baskets",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "Baskets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedTimestamp",
                table: "Baskets",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StoreId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    BasketUniqueBasketId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Baskets_BasketUniqueBasketId",
                        column: x => x.BasketUniqueBasketId,
                        principalTable: "Baskets",
                        principalColumn: "UniqueBasketId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_BasketUniqueBasketId",
                table: "Items",
                column: "BasketUniqueBasketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedTimestamp",
                table: "Baskets",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedTimestamp",
                table: "Baskets",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "getdate()");
        }
    }
}

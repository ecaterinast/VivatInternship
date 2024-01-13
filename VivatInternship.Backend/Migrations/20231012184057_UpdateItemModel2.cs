using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivatInternship.Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItemModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StoreId",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

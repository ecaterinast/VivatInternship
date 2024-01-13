using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivatInternship.Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    UniqueBasketId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfileId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PaymentInitiated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.UniqueBasketId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");
        }
    }
}

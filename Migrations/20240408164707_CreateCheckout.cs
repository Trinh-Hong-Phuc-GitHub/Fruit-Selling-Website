using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FruitSellingWebsite.Migrations
{
    /// <inheritdoc />
    public partial class CreateCheckout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Orders",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Orders",
                newName: "CreatedTime");
        }
    }
}

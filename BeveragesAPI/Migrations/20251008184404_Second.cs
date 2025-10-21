using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeveragesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "/images/default-beverage.jpg");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Beverages",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Beverages");
        }
    }
}

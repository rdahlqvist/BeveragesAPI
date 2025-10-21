using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeveragesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.AddColumn<string>(
                name: "SecretRecipe",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretRecipe",
                table: "Beverages");

            migrationBuilder.AddColumn<string>(
                name: "Recipe",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

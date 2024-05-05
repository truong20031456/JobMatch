using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class asdshdfhjkfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "ApplicationModels");

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ApplicationModels",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "ApplicationModels");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "ApplicationModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

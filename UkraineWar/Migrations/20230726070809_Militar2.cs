using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UkraineWar.Migrations
{
    /// <inheritdoc />
    public partial class Militar2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "MilitaryEquipments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "MilitaryEquipments");
        }
    }
}

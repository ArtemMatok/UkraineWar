using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UkraineWar.Migrations
{
    /// <inheritdoc />
    public partial class SDAS3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "MilitaryEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "MilitaryEquipments");
        }
    }
}

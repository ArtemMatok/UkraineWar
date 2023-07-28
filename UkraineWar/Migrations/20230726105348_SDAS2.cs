using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UkraineWar.Migrations
{
    /// <inheritdoc />
    public partial class SDAS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MilitaryEquipments_Categories_CategoryId",
                table: "MilitaryEquipments");

            migrationBuilder.DropIndex(
                name: "IX_MilitaryEquipments_CategoryId",
                table: "MilitaryEquipments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MilitaryEquipments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MilitaryEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryEquipments_CategoryId",
                table: "MilitaryEquipments",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MilitaryEquipments_Categories_CategoryId",
                table: "MilitaryEquipments",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

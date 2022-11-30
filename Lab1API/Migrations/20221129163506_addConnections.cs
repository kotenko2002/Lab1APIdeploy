using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1API.Migrations
{
    public partial class addConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "СurrencyId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_СurrencyId",
                table: "Users",
                column: "СurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CategoryId",
                table: "Records",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_UserId",
                table: "Records",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Categories_CategoryId",
                table: "Records",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Currencies_СurrencyId",
                table: "Users",
                column: "СurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Categories_CategoryId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Currencies_СurrencyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_СurrencyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Records_CategoryId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_UserId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "СurrencyId",
                table: "Users");
        }
    }
}

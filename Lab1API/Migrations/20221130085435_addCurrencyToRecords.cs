using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1API.Migrations
{
    public partial class addCurrencyToRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Records");
        }
    }
}

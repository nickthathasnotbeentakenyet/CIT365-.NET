using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDesk_Web.Migrations
{
    public partial class priceremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Desk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Desk",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

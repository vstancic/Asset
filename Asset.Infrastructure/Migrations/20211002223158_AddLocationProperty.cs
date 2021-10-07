using Microsoft.EntityFrameworkCore.Migrations;

namespace Asset.Infrastructure.Migrations
{
    public partial class AddLocationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Asset");
        }
    }
}

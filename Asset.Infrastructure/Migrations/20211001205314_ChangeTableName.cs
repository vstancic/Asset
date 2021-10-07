using Microsoft.EntityFrameworkCore.Migrations;

namespace Asset.Infrastructure.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyEntities",
                table: "MyEntities");

            migrationBuilder.RenameTable(
                name: "MyEntities",
                newName: "Asset");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asset",
                table: "Asset",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Asset",
                table: "Asset");

            migrationBuilder.RenameTable(
                name: "Asset",
                newName: "MyEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyEntities",
                table: "MyEntities",
                column: "Id");
        }
    }
}

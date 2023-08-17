using Microsoft.EntityFrameworkCore.Migrations;

namespace entityframe.Migrations
{
    public partial class Shelfnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShelfNumber",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShelfNumber",
                table: "Books");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace entityframe.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE TABLE IF NOT EXISTS ""Books"" (
            ""Id"" TEXT NOT NULL,
            ""Name"" TEXT NOT NULL,
            ""IBAN"" TEXT NOT NULL,
            ""Author"" TEXT NOT NULL,
            ""InternalBookId"" INTEGER NOT NULL,
            PRIMARY KEY(""Id"")
        );
    ");
            /*migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IBAN = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    InternalBookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

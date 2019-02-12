using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LicenceTrackerProto.Data.Migrations
{
    public partial class AddLicencev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    User = table.Column<string>(nullable: true),
                    ID = table.Column<Guid>(nullable: false),
                    LicenceKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");
        }
    }
}

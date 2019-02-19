using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LicenceTrackerProto.Data.Migrations
{
    public partial class SeedLicences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ID", "LicenceKey", "User" },
                values: new object[] { new Guid("8151c7c2-24ba-4d10-a89d-b8fa55f03bf7"), "VS_Pro", "Geoff" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ID", "LicenceKey", "User" },
                values: new object[] { new Guid("2d9f8a59-f25c-4cb2-9d14-3afb7163c033"), "WS_Ent", "Alice" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "ID",
                keyValue: new Guid("2d9f8a59-f25c-4cb2-9d14-3afb7163c033"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "ID",
                keyValue: new Guid("8151c7c2-24ba-4d10-a89d-b8fa55f03bf7"));
        }
    }
}

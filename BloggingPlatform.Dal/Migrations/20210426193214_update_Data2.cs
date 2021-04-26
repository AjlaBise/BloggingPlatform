using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggingPlatform.Dal.Migrations
{
    public partial class update_Data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 22, 21, 32, 13, 808, DateTimeKind.Local).AddTicks(9862), new DateTime(2021, 4, 25, 21, 32, 13, 815, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 24, 21, 32, 13, 815, DateTimeKind.Local).AddTicks(5316), new DateTime(2021, 4, 26, 21, 32, 13, 815, DateTimeKind.Local).AddTicks(5396) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 22, 20, 49, 52, 18, DateTimeKind.Local).AddTicks(5815), new DateTime(2021, 4, 25, 20, 49, 52, 22, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 24, 20, 49, 52, 22, DateTimeKind.Local).AddTicks(5967), new DateTime(2021, 4, 26, 20, 49, 52, 22, DateTimeKind.Local).AddTicks(6000) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggingPlatform.Dal.Migrations
{
    public partial class update_Data4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 22, 21, 39, 10, 468, DateTimeKind.Local).AddTicks(6085), new DateTime(2021, 4, 25, 21, 39, 10, 473, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 24, 21, 39, 10, 473, DateTimeKind.Local).AddTicks(8313), new DateTime(2021, 4, 26, 21, 39, 10, 473, DateTimeKind.Local).AddTicks(8348) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

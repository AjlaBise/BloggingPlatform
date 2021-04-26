using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggingPlatform.Dal.Migrations
{
    public partial class update_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 22, 19, 52, 34, 656, DateTimeKind.Local).AddTicks(2656), new DateTime(2021, 4, 25, 19, 52, 34, 660, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 24, 19, 52, 34, 660, DateTimeKind.Local).AddTicks(4530), new DateTime(2021, 4, 26, 19, 52, 34, 660, DateTimeKind.Local).AddTicks(4562) });
        }
    }
}

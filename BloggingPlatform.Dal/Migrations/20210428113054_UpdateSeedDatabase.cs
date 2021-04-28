using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggingPlatform.Dal.Migrations
{
    public partial class UpdateSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 24, 13, 30, 53, 286, DateTimeKind.Local).AddTicks(7605), new DateTime(2021, 4, 27, 13, 30, 53, 292, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Slug", "Tag", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 26, 13, 30, 53, 292, DateTimeKind.Local).AddTicks(5973), "augmented-reality-ios-application-2", 2, new DateTime(2021, 4, 28, 13, 30, 53, 292, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Tag", "Title", "UpdatedAt" },
                values: new object[] { 3, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2021, 4, 22, 13, 30, 53, 292, DateTimeKind.Local).AddTicks(6068), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application-3", 3, "Augmented Reality iOS Application 3", new DateTime(2021, 4, 26, 13, 30, 53, 292, DateTimeKind.Local).AddTicks(6079) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 23, 12, 2, 45, 74, DateTimeKind.Local).AddTicks(1479), new DateTime(2021, 4, 26, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Slug", "Tag", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(717), "augmented-reality-ios-application 2", 1, new DateTime(2021, 4, 27, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(749) });
        }
    }
}

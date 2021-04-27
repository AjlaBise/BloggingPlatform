using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggingPlatform.Dal.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Tag = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Tag", "Title", "UpdatedAt" },
                values: new object[] { 1, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2021, 4, 23, 12, 2, 45, 74, DateTimeKind.Local).AddTicks(1479), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application", 1, "Augmented Reality iOS Application", new DateTime(2021, 4, 26, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Tag", "Title", "UpdatedAt" },
                values: new object[] { 2, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2021, 4, 25, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(717), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application 2", 1, "Augmented Reality iOS Application 2", new DateTime(2021, 4, 27, 12, 2, 45, 78, DateTimeKind.Local).AddTicks(749) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}

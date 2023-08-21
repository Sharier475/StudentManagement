using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class ADT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 19, 16, 47, 47, 470, DateTimeKind.Unspecified).AddTicks(2838), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 19, 16, 47, 47, 470, DateTimeKind.Unspecified).AddTicks(6768), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 19, 16, 47, 47, 473, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 19, 16, 47, 47, 474, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 6, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 16, 17, 14, 4, 473, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 16, 17, 14, 4, 473, DateTimeKind.Unspecified).AddTicks(9791), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 16, 17, 14, 4, 477, DateTimeKind.Unspecified).AddTicks(5547), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 16, 17, 14, 4, 477, DateTimeKind.Unspecified).AddTicks(8346), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}

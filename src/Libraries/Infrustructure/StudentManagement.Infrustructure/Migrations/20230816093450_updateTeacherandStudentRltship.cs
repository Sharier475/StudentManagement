using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTeacherandStudentRltship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TeacherId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 15, 34, 50, 849, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 6, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 16, 15, 34, 50, 849, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherId",
                table: "Students",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teacher_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teacher_TeacherId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 10, 15, 59, 20, 357, DateTimeKind.Unspecified).AddTicks(9), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 10, 15, 59, 20, 358, DateTimeKind.Unspecified).AddTicks(556), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}

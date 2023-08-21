using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class TeacherTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 10, 15, 59, 20, 357, DateTimeKind.Unspecified).AddTicks(9), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Created", "CreatedBy", "Department", "LastModified", "LastModifiedBy", "Salary", "Status", "TeacherName" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2023, 8, 10, 15, 59, 20, 358, DateTimeKind.Unspecified).AddTicks(556), new TimeSpan(0, 6, 0, 0, 0)), "1", "IT", null, null, 15000.0, 1, "Dipon" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 8, 8, 15, 21, 15, 729, DateTimeKind.Unspecified).AddTicks(6974), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}

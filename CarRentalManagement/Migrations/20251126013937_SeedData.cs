using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(1901), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(1920), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(1923), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2195), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2196), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2198), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2198), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2275), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2275), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2277), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2278), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2280), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 11, 26, 9, 39, 36, 141, DateTimeKind.Local).AddTicks(2282), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

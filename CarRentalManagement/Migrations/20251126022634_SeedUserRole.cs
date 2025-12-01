using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2d69f001-0dba-4aba-a321-2c08e84ea163", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPkTeghQd9e92/zcb9d14vQmxmf7MdCsRwxLwEtZkC76lk9N89S7hNztsnkA6K22Hg==", null, false, "7b018b7e-5f9f-4626-a35d-406dbc2d1127", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9079), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9419), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9422), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9526), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9529), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9532), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9534), new DateTime(2025, 11, 26, 10, 26, 33, 266, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8558), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8578), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8817), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8820), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8909), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8912), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8914), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8916), new DateTime(2025, 11, 26, 10, 16, 35, 306, DateTimeKind.Local).AddTicks(8916) });
        }
    }
}

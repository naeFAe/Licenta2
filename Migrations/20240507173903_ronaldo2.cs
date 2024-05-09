using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Licenta2.Migrations
{
    /// <inheritdoc />
    public partial class ronaldo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ae776f-7580-4d9c-bd2f-fbe12e705cf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c195a77d-9ca7-47a5-9969-8a9919e6d3c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cae8093b-b56b-44f3-a5a9-ff39cc18ea62");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "143d3027-04a0-4a9b-9531-2e1b99612e9b", null, "seller", "seller" },
                    { "b4489982-1f25-41a0-b166-39329515e6ba", null, "client", "client" },
                    { "f12f8b68-1998-407c-8ee5-c9aecfd18336", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "143d3027-04a0-4a9b-9531-2e1b99612e9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4489982-1f25-41a0-b166-39329515e6ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f12f8b68-1998-407c-8ee5-c9aecfd18336");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83ae776f-7580-4d9c-bd2f-fbe12e705cf3", null, "seller", "seller" },
                    { "c195a77d-9ca7-47a5-9969-8a9919e6d3c4", null, "client", "client" },
                    { "cae8093b-b56b-44f3-a5a9-ff39cc18ea62", null, "admin", "admin" }
                });
        }
    }
}

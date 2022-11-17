using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e4301d15-ff71-41da-bc30-6a5420ab3d69");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "29b88a14-543b-43c4-8b01-318b3e21cf7b", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831aa48c-91bc-4a71-b2ed-b71f85892e70", "AQAAAAEAACcQAAAAENIWpDSjLr9z+cIt0o2gvY2kwdFijhy/yzp99vUi+U5WpNFR6DkqfN+tWUWC46rseQ==", "35f6c3a5-1b2f-4c1c-bea7-832353027d50" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "90a8c136-cb30-4e8f-b3d7-624aae1d03f7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d33e0a9-6dce-430e-8446-393ddd6b51cf", "AQAAAAEAACcQAAAAEOJ7T21LAFdiK+HaYUJJCbk9bglUde5Iszas+k6m/Ms6gU1/pTrH4vqXROEkDA7cqQ==", "fb565ae9-3929-4c9c-928d-40910cb21c4d" });
        }
    }
}

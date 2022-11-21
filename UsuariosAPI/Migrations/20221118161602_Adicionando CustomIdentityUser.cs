using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class AdicionandoCustomIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "1906d70d-b57b-4f15-86a9-a3cf8be943b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0ca7d230-3768-44c6-acda-1cd1e08859f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e603e48-b8e2-4403-a883-c908145c8096", "AQAAAAEAACcQAAAAEIxTwsM5/ykAQzaJkSxn/EfgYBNGOJIrHudLDDPEMxuTQg1RT+z8mJJ3mLnLTFvDpQ==", "fcedf4a6-9465-4a8d-942f-db950e5c9ce1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "29b88a14-543b-43c4-8b01-318b3e21cf7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e4301d15-ff71-41da-bc30-6a5420ab3d69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831aa48c-91bc-4a71-b2ed-b71f85892e70", "AQAAAAEAACcQAAAAENIWpDSjLr9z+cIt0o2gvY2kwdFijhy/yzp99vUi+U5WpNFR6DkqfN+tWUWC46rseQ==", "35f6c3a5-1b2f-4c1c-bea7-832353027d50" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhuongBac.Data.Migrations
{
    public partial class SeedingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), "e4b0288e-6214-4edd-9323-c22e398f954f", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), 0, "0163faa1-73cc-4319-8df5-2cbf12d8af0a", new DateTime(1993, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "itpb@gmail.com", true, "Huy", "Lee", false, null, "itpb@gmail.com", "admin", "AQAAAAEAACcQAAAAEIcVMlydCnzGb0lNnEszlR8X//cbkKSDUmXfAKQQUCX6SnxyT56AzrkCDBi/pGQGhg==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"));
        }
    }
}

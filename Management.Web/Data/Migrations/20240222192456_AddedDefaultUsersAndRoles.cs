using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f", "4ce35e3d-d7b3-4d3a-84ad-fc46cd1935f3", "Administrator", "ADMINISTRATOR" },
                    { "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f", "0a96ef2c-fc17-4cf4-80f8-8ba5e21caac2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f", 0, "b1a4278c-beac-42cd-9f4c-10e15b221cd8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEIMHTYFzQve3UpQYTGXR9ck+/RzbS4C8t5jfN/QKiR/zXH5IxzFtIqY3irDmkligwg==", null, false, "d0c4f0b9-d9fe-43d8-8ae8-875910bf4b48", null, false, null },
                    { "d739e4f4-76e9-4ba9-918b-8768753cff65", 0, "a02f3923-64bf-441e-93e2-5ee0d95e1b45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGH0I2X2OTTl+AgP0ftlDyY6P1tRuYuS3Vqn91iSytz8PCCTDbWE5j58Kwwi7oTzxg==", null, false, "19f2ac4a-69c3-4861-b379-c322e3a75504", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f", "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f", "d739e4f4-76e9-4ba9-918b-8768753cff65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f", "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f", "d739e4f4-76e9-4ba9-918b-8768753cff65" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65");
        }
    }
}

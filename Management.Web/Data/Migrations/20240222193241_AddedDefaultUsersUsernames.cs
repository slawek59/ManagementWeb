using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "0472a2b2-652d-40f0-81c1-58834d6451e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "fb99ccf8-9188-4854-a7fd-6370c5a5ffcf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1c536f54-e88a-4e76-b470-1ad32c358090", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEZOl3XteD46mXoVFIx4KBftcBP2QkgQQgwErX+lL30g6E0q/nOOvBF116oewbvXyQ==", "9edc157c-a580-4c46-ad97-5230aeafe7a1", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "676e0698-4f1b-4dbe-860d-ca69e6627c67", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELOH4MXgni+DsPDGD5rw6ZO1gcwVe5KwHdTTYzLbLJqsZy1rP3IBpxNLdikI4S4xIA==", "47f0f249-7f38-445d-90cd-0781a1e9d1c1", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "4ce35e3d-d7b3-4d3a-84ad-fc46cd1935f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "0a96ef2c-fc17-4cf4-80f8-8ba5e21caac2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b1a4278c-beac-42cd-9f4c-10e15b221cd8", false, null, "AQAAAAEAACcQAAAAEIMHTYFzQve3UpQYTGXR9ck+/RzbS4C8t5jfN/QKiR/zXH5IxzFtIqY3irDmkligwg==", "d0c4f0b9-d9fe-43d8-8ae8-875910bf4b48", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a02f3923-64bf-441e-93e2-5ee0d95e1b45", false, null, "AQAAAAEAACcQAAAAEGH0I2X2OTTl+AgP0ftlDyY6P1tRuYuS3Vqn91iSytz8PCCTDbWE5j58Kwwi7oTzxg==", "19f2ac4a-69c3-4861-b379-c322e3a75504", null });
        }
    }
}

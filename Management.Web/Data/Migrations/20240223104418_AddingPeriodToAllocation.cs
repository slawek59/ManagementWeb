using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "2ece205e-b1b3-40fc-9f4e-21b0f8824f1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "7225162d-0d17-4046-8fb2-b94ad769ec96");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed4f7ee8-22aa-469f-998d-31a7055083ea", "AQAAAAEAACcQAAAAEL6mqcCqhV+Z7nCZidXmskCOabUEjuUhZSzHe2kwke4+03On/EBeTiqCGUDTYEB+dA==", "ba21c916-dd2b-4424-a3be-5e2c210ccb6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05864f07-adfe-40b4-b6ac-425f89d79058", "AQAAAAEAACcQAAAAEKyoTXC9KKWNny3raojR/3Aafp3k9N9SRV/kSoe3R5moNC9zAAX73yvRDGLVxtWplQ==", "36bb9a80-9158-44f3-9979-d08dba855eb1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c536f54-e88a-4e76-b470-1ad32c358090", "AQAAAAEAACcQAAAAEEZOl3XteD46mXoVFIx4KBftcBP2QkgQQgwErX+lL30g6E0q/nOOvBF116oewbvXyQ==", "9edc157c-a580-4c46-ad97-5230aeafe7a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "676e0698-4f1b-4dbe-860d-ca69e6627c67", "AQAAAAEAACcQAAAAELOH4MXgni+DsPDGD5rw6ZO1gcwVe5KwHdTTYzLbLJqsZy1rP3IBpxNLdikI4S4xIA==", "47f0f249-7f38-445d-90cd-0781a1e9d1c1" });
        }
    }
}

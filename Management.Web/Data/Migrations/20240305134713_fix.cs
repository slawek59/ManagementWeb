using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "3daab440-9976-4ee4-8b08-a5c0c35c170c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "5d451a92-f489-4bdb-bf45-8d792e8ae994");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f68311f6-cf83-4d19-a6ff-bd567fe079d4", "AQAAAAEAACcQAAAAEIZBRKEsfqFB3U6pJPoHo0Qp3QxSfDOal+fGQrpNfGn9qCU5edW2w18OIGpeATDFgQ==", "c6e73955-43c1-455d-bc16-8cd0375484c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8b10be5-4e6a-4107-9c13-ace4044ed234", "AQAAAAEAACcQAAAAEF4jj7U/uqizp1386de6mdMLuQ8FfIAnVvFFj+x++wVnAzz49DwL6aXLQ+wmusstvg==", "fab7c32d-5588-4260-bf81-fb13168645ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

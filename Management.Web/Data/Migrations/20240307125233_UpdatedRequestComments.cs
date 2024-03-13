using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "67c8e673-c760-419d-a398-db83c7e927a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "fab1c420-3026-4a4f-9616-33b848e1618d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8204b0-e2da-4f3b-9f5c-e9bae986566c", "AQAAAAEAACcQAAAAEM/kreZ3mRoiEhzicwErT8rvrOVjM/ZPbNoXKynEECU6aueDipP5I1QM2NnmH/6i5w==", "a0eebb18-9b55-494e-a353-4084051a9d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be02731d-8919-41fe-bb9d-2f1f96c7bdcc", "AQAAAAEAACcQAAAAEKHsJ0H98+l7iR9wh6fLOlINvgARCL9Y/lL+cwLBpB06IHbr5MUgYqv1p3vaLZ3evQ==", "b65bd47a-ecd8-4aad-9e52-f4cb28d9a6fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                column: "ConcurrencyStamp",
                value: "907db0ef-cfa8-4d88-8bc5-353aac39eea3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                column: "ConcurrencyStamp",
                value: "9cb802ea-d431-4225-8e24-5dce877d33fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d10c6f84-7bee-4827-87de-a96e89fdaee0", "AQAAAAEAACcQAAAAENyxwYAfZtoFI0pOfoieuh44I0D/pJy4EszT813rBKlsg3Nnivr6aintFTTUUanOQQ==", "af859a82-3274-4d7f-8646-9dc65fcee364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d739e4f4-76e9-4ba9-918b-8768753cff65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d306be59-b83f-492b-9668-847a12895583", "AQAAAAEAACcQAAAAEE2ul14ccFjjv0oT7pPeWIBzrBcYULHm9UoppHQTHSx9uuFnc6laGci1lTj4d3Uf+g==", "9bbb7fff-edc8-438b-ba17-3a2802635606" });
        }
    }
}

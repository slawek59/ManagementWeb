using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}

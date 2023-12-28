using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class log : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 18, 59, 0, 57, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 11, 57, 2, 575, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 53, 44, 878, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 3, 52, 13, 677, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 20, 32, 37, 451, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 1, 42, 9, 142, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 24, 1, 377, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 16, 49, 38, 835, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 1, 33, 279, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 20, 49, 49, 459, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 8, 24, 37, 865, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 20, 57, 936, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 1, 9, 26, 339, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 26, 21, 935, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 22, 10, 45, 626, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 10, 21, 233, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 41, 45, 247, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 41, 6, 766, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 11, 31, 3, 271, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 2, 25, 921, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserType",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserType",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserType",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserType",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserType",
                value: "Admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 12, 0, 23, 663, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 4, 58, 26, 180, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 55, 8, 483, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 12, 20, 20, 53, 37, 281, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 13, 34, 1, 56, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 12, 20, 18, 43, 32, 747, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 7, 25, 24, 982, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 51, 2, 440, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 2, 56, 884, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 13, 51, 13, 64, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 1, 26, 1, 470, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageDate",
                value: new DateTime(2023, 12, 20, 19, 22, 21, 541, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageDate",
                value: new DateTime(2023, 12, 20, 18, 10, 49, 944, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageDate",
                value: new DateTime(2023, 12, 20, 19, 27, 45, 539, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 15, 12, 9, 230, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 7, 11, 44, 837, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 7, 43, 8, 852, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 3, 42, 30, 370, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 4, 32, 26, 875, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 3, 3, 49, 526, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserType",
                value: 0);
        }
    }
}

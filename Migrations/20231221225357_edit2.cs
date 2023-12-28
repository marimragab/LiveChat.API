using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 19, 5, 13, 576, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 12, 3, 16, 94, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 59, 58, 397, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 3, 58, 27, 195, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 20, 38, 50, 970, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 1, 48, 22, 661, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 30, 14, 896, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 16, 55, 52, 354, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 7, 46, 798, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 20, 56, 2, 978, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 8, 30, 51, 384, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 27, 11, 455, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 1, 15, 39, 858, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 2, 32, 35, 454, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 22, 16, 59, 145, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 16, 34, 752, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 14, 47, 58, 766, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 47, 20, 285, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 11, 37, 16, 790, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 8, 39, 440, DateTimeKind.Local).AddTicks(6832));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

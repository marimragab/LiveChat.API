using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class upda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 2, 34, 12, 349, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 19, 32, 14, 866, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 17, 28, 57, 169, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 11, 27, 25, 967, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 4, 7, 49, 742, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 17, 21, 433, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 21, 59, 13, 668, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 0, 24, 51, 126, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 16, 36, 45, 570, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 4, 25, 1, 750, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 15, 59, 50, 156, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 56, 10, 227, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 8, 44, 38, 630, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 1, 34, 225, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 5, 45, 57, 916, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 21, 45, 33, 523, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 22, 16, 57, 538, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 18, 16, 19, 56, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 19, 6, 15, 561, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 17, 37, 38, 212, DateTimeKind.Local).AddTicks(3006));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 2, 40, 6, 122, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 19, 38, 8, 642, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 17, 34, 50, 944, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 11, 33, 19, 743, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 4, 13, 43, 517, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 9, 23, 15, 208, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 22, 5, 7, 443, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 0, 30, 44, 901, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 16, 42, 39, 345, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 4, 30, 55, 525, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 16, 5, 43, 931, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 2, 4, 2, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 8, 50, 32, 405, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 10, 7, 28, 1, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageDate",
                value: new DateTime(2023, 12, 22, 5, 51, 51, 692, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 21, 51, 27, 299, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 22, 22, 51, 313, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 18, 22, 12, 832, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 19, 12, 9, 338, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageDate",
                value: new DateTime(2023, 12, 21, 17, 43, 31, 988, DateTimeKind.Local).AddTicks(8427));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

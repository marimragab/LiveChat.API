using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserConnections_Users_UserId",
                table: "UserConnections");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserConnections",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserConnections_AspNetUsers_UserId",
                table: "UserConnections",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserConnections_AspNetUsers_UserId",
                table: "UserConnections");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserConnections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "SenderId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiverId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "UserType" },
                values: new object[,]
                {
                    { 1, "Justin.Konopelski64@yahoo.com", "https://picsum.photos/640/480/?image=348", "Justin Konopelski", "sk41HzFizN", "Admin" },
                    { 2, "Zachary_Howe77@yahoo.com", "https://picsum.photos/640/480/?image=1078", "Zachary Howe", "6U65Y1WAR0", "User" },
                    { 3, "Dan.Shields@hotmail.com", "https://picsum.photos/640/480/?image=523", "Dan Shields", "yBwGanBPtC", "User" },
                    { 4, "Jeremiah.Gislason@gmail.com", "https://picsum.photos/640/480/?image=166", "Jeremiah Gislason", "O4a2SPEVMk", "Admin" },
                    { 5, "Mitchell85@gmail.com", "https://picsum.photos/640/480/?image=575", "Mitchell Parker", "Le9MWKvg3a", "User" },
                    { 6, "Shari47@gmail.com", "https://picsum.photos/640/480/?image=491", "Shari Morar", "bdvKpioDAY", "Admin" },
                    { 7, "Victoria.Rath37@gmail.com", "https://picsum.photos/640/480/?image=776", "Victoria Rath", "ygYCezOcEe", "User" },
                    { 8, "Calvin_Anderson@yahoo.com", "https://picsum.photos/640/480/?image=281", "Calvin Anderson", "bKQbjLiZka", "User" },
                    { 9, "Rudolph.McKenzie35@hotmail.com", "https://picsum.photos/640/480/?image=543", "Rudolph McKenzie", "VNHZzd1MfZ", "User" },
                    { 10, "Opal_Boehm62@yahoo.com", "https://picsum.photos/640/480/?image=363", "Opal Boehm", "_dkeqMsa8V", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentUrl", "Content", "IsDeleted", "IsRead", "IsSent", "MessageDate", "MessageType", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 1, "http://queenie.name", "Beatae veniam magni iusto voluptatem provident incidunt saepe aut non.", false, false, true, new DateTime(2023, 12, 27, 6, 3, 15, 253, DateTimeKind.Local).AddTicks(6119), 0, 7, 7 },
                    { 2, "http://jerald.name", "Aut quos dolorem illo qui.", false, true, false, new DateTime(2023, 12, 26, 23, 1, 17, 771, DateTimeKind.Local).AddTicks(3903), 0, 1, 7 },
                    { 3, "http://jace.name", "Ut mollitia dolores dolor fugiat nobis sint.", false, true, true, new DateTime(2023, 12, 26, 20, 58, 0, 73, DateTimeKind.Local).AddTicks(7285), 1, 7, 7 },
                    { 4, "http://lesley.biz", "Odit autem nemo eum et repellat quo.", true, true, false, new DateTime(2023, 12, 26, 14, 56, 28, 872, DateTimeKind.Local).AddTicks(3715), 1, 4, 2 },
                    { 5, "http://loren.org", "Ut et sed nostrum aut sed numquam.", true, true, false, new DateTime(2023, 12, 27, 7, 36, 52, 646, DateTimeKind.Local).AddTicks(7040), 3, 6, 6 },
                    { 6, "https://leland.net", "Nemo rerum ut eos et.", true, true, false, new DateTime(2023, 12, 26, 12, 46, 24, 338, DateTimeKind.Local).AddTicks(1025), 3, 3, 3 },
                    { 7, "https://clemmie.com", "Sed quibusdam reiciendis illum illum aut dolorem qui omnis.", true, true, false, new DateTime(2023, 12, 27, 1, 28, 16, 572, DateTimeKind.Local).AddTicks(5040), 2, 9, 2 },
                    { 8, "http://elliott.net", "Fuga ea quibusdam sunt veritatis et.", true, false, false, new DateTime(2023, 12, 27, 3, 53, 54, 30, DateTimeKind.Local).AddTicks(6551), 3, 1, 8 },
                    { 9, "https://jules.com", "Omnis odio sed quisquam occaecati officia harum.", false, false, false, new DateTime(2023, 12, 26, 20, 5, 48, 474, DateTimeKind.Local).AddTicks(9202), 2, 9, 4 },
                    { 10, "https://winfield.com", "Quo repellat voluptate possimus.", false, false, false, new DateTime(2023, 12, 27, 7, 54, 4, 654, DateTimeKind.Local).AddTicks(9863), 2, 2, 8 },
                    { 11, "http://taya.biz", "Cupiditate hic nihil.", false, true, false, new DateTime(2023, 12, 26, 19, 28, 53, 60, DateTimeKind.Local).AddTicks(7165), 3, 10, 4 },
                    { 12, "http://aileen.biz", "Quidem omnis molestiae.", false, true, true, new DateTime(2023, 12, 26, 13, 25, 13, 131, DateTimeKind.Local).AddTicks(8790), 1, 7, 1 },
                    { 13, "https://rod.info", "Est expedita aliquam ipsa possimus praesentium alias explicabo.", false, true, true, new DateTime(2023, 12, 26, 12, 13, 41, 535, DateTimeKind.Local).AddTicks(61), 2, 4, 3 },
                    { 14, "http://baylee.name", "Fugiat ut modi architecto expedita aperiam adipisci consequatur autem.", true, true, false, new DateTime(2023, 12, 26, 13, 30, 37, 130, DateTimeKind.Local).AddTicks(2987), 1, 9, 10 },
                    { 15, "http://alf.biz", "Dignissimos quae perspiciatis omnis incidunt omnis fuga.", true, false, true, new DateTime(2023, 12, 27, 9, 15, 0, 821, DateTimeKind.Local).AddTicks(3693), 3, 5, 5 },
                    { 16, "http://dario.name", "Mollitia consequatur natus qui et neque natus.", true, false, false, new DateTime(2023, 12, 27, 1, 14, 36, 428, DateTimeKind.Local).AddTicks(3618), 1, 4, 8 },
                    { 17, "https://ashlynn.net", "Eligendi ducimus nulla debitis velit dicta maxime porro qui.", true, true, false, new DateTime(2023, 12, 27, 1, 46, 0, 442, DateTimeKind.Local).AddTicks(9409), 1, 1, 9 },
                    { 18, "https://wilbert.net", "Quam vel eius temporibus corporis doloremque voluptatem recusandae molestiae et.", true, false, true, new DateTime(2023, 12, 26, 21, 45, 21, 961, DateTimeKind.Local).AddTicks(2098), 2, 5, 6 },
                    { 19, "http://frida.biz", "Repudiandae impedit eos modi alias recusandae dolorem ut.", true, false, false, new DateTime(2023, 12, 26, 22, 35, 18, 466, DateTimeKind.Local).AddTicks(1885), 0, 6, 1 },
                    { 20, "https://lula.biz", "Assumenda consequatur quis perspiciatis fugiat a.", false, false, true, new DateTime(2023, 12, 26, 21, 6, 41, 116, DateTimeKind.Local).AddTicks(6802), 2, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserConnections",
                columns: new[] { "Id", "ConnectionId", "UserId" },
                values: new object[,]
                {
                    { 1, "50f0bc8b-099c-e61a-5f56-c571a1badfb4", 2 },
                    { 2, "f31ce4e6-405b-a884-2daa-99281286bbb7", 9 },
                    { 3, "5592dc29-6810-1bfe-1c1f-a97be8cebda0", 6 },
                    { 4, "d7179e82-7b30-a76c-6e5e-81be4dcf0aba", 8 },
                    { 5, "1c220390-7cd5-d81e-3e20-da2d44dbdb88", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserConnections_Users_UserId",
                table: "UserConnections",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

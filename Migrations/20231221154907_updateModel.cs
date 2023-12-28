﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiveChat.API.Migrations
{
    /// <inheritdoc />
    public partial class updateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "UserConnections",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.RenameColumn(
                name: "Sended",
                table: "Messages",
                newName: "MessageDate");

            migrationBuilder.RenameColumn(
                name: "Read",
                table: "Messages",
                newName: "isSent");

            migrationBuilder.AddColumn<bool>(
                name: "isRead",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "UserType" },
                values: new object[,]
                {
                    { 1, "Justin.Konopelski64@yahoo.com", "https://picsum.photos/640/480/?image=348", "Justin Konopelski", "sk41HzFizN", 0 },
                    { 2, "Zachary_Howe77@yahoo.com", "https://picsum.photos/640/480/?image=1078", "Zachary Howe", "6U65Y1WAR0", 1 },
                    { 3, "Dan.Shields@hotmail.com", "https://picsum.photos/640/480/?image=523", "Dan Shields", "yBwGanBPtC", 1 },
                    { 4, "Jeremiah.Gislason@gmail.com", "https://picsum.photos/640/480/?image=166", "Jeremiah Gislason", "O4a2SPEVMk", 0 },
                    { 5, "Mitchell85@gmail.com", "https://picsum.photos/640/480/?image=575", "Mitchell Parker", "Le9MWKvg3a", 1 },
                    { 6, "Shari47@gmail.com", "https://picsum.photos/640/480/?image=491", "Shari Morar", "bdvKpioDAY", 0 },
                    { 7, "Victoria.Rath37@gmail.com", "https://picsum.photos/640/480/?image=776", "Victoria Rath", "ygYCezOcEe", 1 },
                    { 8, "Calvin_Anderson@yahoo.com", "https://picsum.photos/640/480/?image=281", "Calvin Anderson", "bKQbjLiZka", 1 },
                    { 9, "Rudolph.McKenzie35@hotmail.com", "https://picsum.photos/640/480/?image=543", "Rudolph McKenzie", "VNHZzd1MfZ", 1 },
                    { 10, "Opal_Boehm62@yahoo.com", "https://picsum.photos/640/480/?image=363", "Opal Boehm", "_dkeqMsa8V", 0 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentUrl", "Content", "IsDeleted", "MessageDate", "MessageType", "ReceiverId", "SenderId", "isRead", "isSent" },
                values: new object[,]
                {
                    { 1, "http://queenie.name", "Beatae veniam magni iusto voluptatem provident incidunt saepe aut non.", false, new DateTime(2023, 12, 21, 12, 0, 23, 663, DateTimeKind.Local).AddTicks(1057), 0, 7, 7, false, true },
                    { 2, "http://jerald.name", "Aut quos dolorem illo qui.", false, new DateTime(2023, 12, 21, 4, 58, 26, 180, DateTimeKind.Local).AddTicks(9420), 0, 1, 7, true, false },
                    { 3, "http://jace.name", "Ut mollitia dolores dolor fugiat nobis sint.", false, new DateTime(2023, 12, 21, 2, 55, 8, 483, DateTimeKind.Local).AddTicks(2811), 1, 7, 7, true, true },
                    { 4, "http://lesley.biz", "Odit autem nemo eum et repellat quo.", true, new DateTime(2023, 12, 20, 20, 53, 37, 281, DateTimeKind.Local).AddTicks(9306), 1, 4, 2, true, false },
                    { 5, "http://loren.org", "Ut et sed nostrum aut sed numquam.", true, new DateTime(2023, 12, 21, 13, 34, 1, 56, DateTimeKind.Local).AddTicks(2553), 3, 6, 6, true, false },
                    { 6, "https://leland.net", "Nemo rerum ut eos et.", true, new DateTime(2023, 12, 20, 18, 43, 32, 747, DateTimeKind.Local).AddTicks(6518), 3, 3, 3, true, false },
                    { 7, "https://clemmie.com", "Sed quibusdam reiciendis illum illum aut dolorem qui omnis.", true, new DateTime(2023, 12, 21, 7, 25, 24, 982, DateTimeKind.Local).AddTicks(532), 2, 9, 2, true, false },
                    { 8, "http://elliott.net", "Fuga ea quibusdam sunt veritatis et.", true, new DateTime(2023, 12, 21, 9, 51, 2, 440, DateTimeKind.Local).AddTicks(2042), 3, 1, 8, false, false },
                    { 9, "https://jules.com", "Omnis odio sed quisquam occaecati officia harum.", false, new DateTime(2023, 12, 21, 2, 2, 56, 884, DateTimeKind.Local).AddTicks(4693), 2, 9, 4, false, false },
                    { 10, "https://winfield.com", "Quo repellat voluptate possimus.", false, new DateTime(2023, 12, 21, 13, 51, 13, 64, DateTimeKind.Local).AddTicks(5401), 2, 2, 8, false, false },
                    { 11, "http://taya.biz", "Cupiditate hic nihil.", false, new DateTime(2023, 12, 21, 1, 26, 1, 470, DateTimeKind.Local).AddTicks(2717), 3, 10, 4, true, false },
                    { 12, "http://aileen.biz", "Quidem omnis molestiae.", false, new DateTime(2023, 12, 20, 19, 22, 21, 541, DateTimeKind.Local).AddTicks(4268), 1, 7, 1, true, true },
                    { 13, "https://rod.info", "Est expedita aliquam ipsa possimus praesentium alias explicabo.", false, new DateTime(2023, 12, 20, 18, 10, 49, 944, DateTimeKind.Local).AddTicks(5537), 2, 4, 3, true, true },
                    { 14, "http://baylee.name", "Fugiat ut modi architecto expedita aperiam adipisci consequatur autem.", true, new DateTime(2023, 12, 20, 19, 27, 45, 539, DateTimeKind.Local).AddTicks(8466), 1, 9, 10, true, false },
                    { 15, "http://alf.biz", "Dignissimos quae perspiciatis omnis incidunt omnis fuga.", true, new DateTime(2023, 12, 21, 15, 12, 9, 230, DateTimeKind.Local).AddTicks(9173), 3, 5, 5, false, true },
                    { 16, "http://dario.name", "Mollitia consequatur natus qui et neque natus.", true, new DateTime(2023, 12, 21, 7, 11, 44, 837, DateTimeKind.Local).AddTicks(9148), 1, 4, 8, false, false },
                    { 17, "https://ashlynn.net", "Eligendi ducimus nulla debitis velit dicta maxime porro qui.", true, new DateTime(2023, 12, 21, 7, 43, 8, 852, DateTimeKind.Local).AddTicks(4890), 1, 1, 9, true, false },
                    { 18, "https://wilbert.net", "Quam vel eius temporibus corporis doloremque voluptatem recusandae molestiae et.", true, new DateTime(2023, 12, 21, 3, 42, 30, 370, DateTimeKind.Local).AddTicks(7576), 2, 5, 6, false, true },
                    { 19, "http://frida.biz", "Repudiandae impedit eos modi alias recusandae dolorem ut.", true, new DateTime(2023, 12, 21, 4, 32, 26, 875, DateTimeKind.Local).AddTicks(7364), 0, 6, 1, false, false },
                    { 20, "https://lula.biz", "Assumenda consequatur quis perspiciatis fugiat a.", false, new DateTime(2023, 12, 21, 3, 3, 49, 526, DateTimeKind.Local).AddTicks(2284), 2, 6, 3, false, true }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "isRead",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "isSent",
                table: "Messages",
                newName: "Read");

            migrationBuilder.RenameColumn(
                name: "MessageDate",
                table: "Messages",
                newName: "Sended");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "UserType" },
                values: new object[,]
                {
                    { -10, "Opal_Boehm62@yahoo.com", "https://picsum.photos/640/480/?image=363", "Opal Boehm", "_dkeqMsa8V", 0 },
                    { -9, "Rudolph.McKenzie35@hotmail.com", "https://picsum.photos/640/480/?image=543", "Rudolph McKenzie", "VNHZzd1MfZ", 1 },
                    { -8, "Calvin_Anderson@yahoo.com", "https://picsum.photos/640/480/?image=281", "Calvin Anderson", "bKQbjLiZka", 1 },
                    { -7, "Victoria.Rath37@gmail.com", "https://picsum.photos/640/480/?image=776", "Victoria Rath", "ygYCezOcEe", 1 },
                    { -6, "Shari47@gmail.com", "https://picsum.photos/640/480/?image=491", "Shari Morar", "bdvKpioDAY", 0 },
                    { -5, "Mitchell85@gmail.com", "https://picsum.photos/640/480/?image=575", "Mitchell Parker", "Le9MWKvg3a", 1 },
                    { -4, "Jeremiah.Gislason@gmail.com", "https://picsum.photos/640/480/?image=166", "Jeremiah Gislason", "O4a2SPEVMk", 0 },
                    { -3, "Dan.Shields@hotmail.com", "https://picsum.photos/640/480/?image=523", "Dan Shields", "yBwGanBPtC", 1 },
                    { -2, "Zachary_Howe77@yahoo.com", "https://picsum.photos/640/480/?image=1078", "Zachary Howe", "6U65Y1WAR0", 1 },
                    { -1, "Justin.Konopelski64@yahoo.com", "https://picsum.photos/640/480/?image=348", "Justin Konopelski", "sk41HzFizN", 0 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentUrl", "Content", "IsDeleted", "MessageType", "Read", "ReceiverId", "Sended", "SenderId" },
                values: new object[,]
                {
                    { -20, "http://emiliano.org", "Asperiores quam vel.", false, 1, true, -6, new DateTime(2023, 12, 20, 7, 0, 49, 167, DateTimeKind.Local).AddTicks(8181), -10 },
                    { -19, "https://lindsay.com", "Maxime porro qui.", true, 2, true, -9, new DateTime(2023, 12, 20, 2, 7, 49, 69, DateTimeKind.Local).AddTicks(2348), -4 },
                    { -18, "https://matt.info", "Rem deserunt autem quia incidunt in.", false, 3, true, -5, new DateTime(2023, 12, 20, 2, 12, 14, 335, DateTimeKind.Local).AddTicks(6636), -9 },
                    { -17, "http://keenan.info", "Numquam consequatur deleniti.", false, 2, false, -6, new DateTime(2023, 12, 20, 2, 0, 57, 63, DateTimeKind.Local).AddTicks(5668), -2 },
                    { -16, "https://bernardo.biz", "Quaerat sapiente at dolorum dignissimos quae perspiciatis.", true, 2, false, -1, new DateTime(2023, 12, 19, 17, 36, 40, 238, DateTimeKind.Local).AddTicks(2429), -5 },
                    { -15, "https://hershel.biz", "Modi architecto expedita aperiam.", true, 2, true, -2, new DateTime(2023, 12, 20, 7, 31, 51, 652, DateTimeKind.Local).AddTicks(7931), -5 },
                    { -14, "http://kali.biz", "Maiores optio nesciunt.", false, 1, false, -9, new DateTime(2023, 12, 20, 10, 50, 21, 189, DateTimeKind.Local).AddTicks(3617), -9 },
                    { -13, "https://deondre.com", "Sit ad et perferendis.", false, 3, false, -1, new DateTime(2023, 12, 19, 20, 51, 48, 30, DateTimeKind.Local).AddTicks(4898), -5 },
                    { -12, "https://tiara.org", "Repudiandae eius saepe autem.", true, 2, false, -1, new DateTime(2023, 12, 19, 14, 31, 59, 707, DateTimeKind.Local).AddTicks(8497), -1 },
                    { -11, "https://maynard.net", "Dolorem est nihil debitis accusamus maiores alias deserunt porro.", true, 2, false, -9, new DateTime(2023, 12, 20, 7, 26, 34, 236, DateTimeKind.Local).AddTicks(3006), -2 },
                    { -10, "http://ryan.com", "Occaecati officia harum expedita nulla possimus tenetur iste.", true, 2, false, -5, new DateTime(2023, 12, 19, 23, 37, 4, 32, DateTimeKind.Local).AddTicks(6897), -10 },
                    { -9, "https://aurelio.name", "Veritatis et sit laudantium sunt soluta ducimus.", false, 3, false, -3, new DateTime(2023, 12, 20, 4, 56, 3, 343, DateTimeKind.Local).AddTicks(8456), -5 },
                    { -8, "http://shayna.info", "Aut dolorem qui omnis et corporis eum error sint.", true, 2, false, -8, new DateTime(2023, 12, 20, 7, 33, 51, 377, DateTimeKind.Local).AddTicks(8630), -5 },
                    { -7, "http://paris.com", "Voluptatem accusamus facere id.", false, 3, true, -9, new DateTime(2023, 12, 19, 17, 46, 23, 463, DateTimeKind.Local).AddTicks(9826), -10 },
                    { -6, "http://sheridan.org", "Harum fugiat necessitatibus.", false, 0, true, -10, new DateTime(2023, 12, 19, 23, 25, 46, 240, DateTimeKind.Local).AddTicks(5609), -1 },
                    { -5, "http://cristopher.biz", "Nemo deserunt ut et.", true, 1, false, -6, new DateTime(2023, 12, 19, 23, 24, 26, 582, DateTimeKind.Local).AddTicks(3605), -3 },
                    { -4, "http://nels.com", "Distinctio excepturi odit autem nemo eum et repellat.", false, 2, true, -5, new DateTime(2023, 12, 19, 19, 5, 3, 132, DateTimeKind.Local).AddTicks(3437), -4 },
                    { -3, "http://ashleigh.biz", "Mollitia dolores dolor fugiat nobis.", false, 1, false, -4, new DateTime(2023, 12, 19, 23, 49, 59, 23, DateTimeKind.Local).AddTicks(4796), -6 },
                    { -2, "http://katlynn.com", "Consequatur aut quos dolorem illo qui sed occaecati.", false, 2, true, -7, new DateTime(2023, 12, 20, 11, 44, 35, 461, DateTimeKind.Local).AddTicks(4882), -1 },
                    { -1, "http://jackie.net", "Beatae veniam magni iusto voluptatem provident incidunt saepe aut non.", false, 2, false, -7, new DateTime(2023, 12, 20, 6, 25, 3, 879, DateTimeKind.Local).AddTicks(9145), -2 }
                });

            migrationBuilder.InsertData(
                table: "UserConnections",
                columns: new[] { "Id", "ConnectionId", "UserId" },
                values: new object[,]
                {
                    { -5, "aa2da884-2899-8612-bbb7-c829dc925510", -7 },
                    { -4, "565fe61a-71c5-baa1-dfb4-72e6e41cf35b", -4 },
                    { -3, "888aec6e-549d-68bc-8334-cb8bbcf0509c", -2 },
                    { -2, "eecf7d36-eb3e-b594-9883-a5ac7118027c", -9 },
                    { -1, "6f365c04-3777-9217-5635-f5d7b6f395b7", -2 }
                });
        }
    }
}

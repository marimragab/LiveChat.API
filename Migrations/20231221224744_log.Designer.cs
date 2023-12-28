﻿// <auto-generated />
using System;
using LiveChat.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LiveChat.API.Migrations
{
    [DbContext(typeof(ChatEntities))]
    [Migration("20231221224744_log")]
    partial class log
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LiveChat.API.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttachmentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.Property<bool>("isSent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttachmentUrl = "http://queenie.name",
                            Content = "Beatae veniam magni iusto voluptatem provident incidunt saepe aut non.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 18, 59, 0, 57, DateTimeKind.Local).AddTicks(7888),
                            MessageType = 0,
                            ReceiverId = 7,
                            SenderId = 7,
                            isRead = false,
                            isSent = true
                        },
                        new
                        {
                            Id = 2,
                            AttachmentUrl = "http://jerald.name",
                            Content = "Aut quos dolorem illo qui.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 11, 57, 2, 575, DateTimeKind.Local).AddTicks(9714),
                            MessageType = 0,
                            ReceiverId = 1,
                            SenderId = 7,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 3,
                            AttachmentUrl = "http://jace.name",
                            Content = "Ut mollitia dolores dolor fugiat nobis sint.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 9, 53, 44, 878, DateTimeKind.Local).AddTicks(3437),
                            MessageType = 1,
                            ReceiverId = 7,
                            SenderId = 7,
                            isRead = true,
                            isSent = true
                        },
                        new
                        {
                            Id = 4,
                            AttachmentUrl = "http://lesley.biz",
                            Content = "Odit autem nemo eum et repellat quo.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 3, 52, 13, 677, DateTimeKind.Local).AddTicks(95),
                            MessageType = 1,
                            ReceiverId = 4,
                            SenderId = 2,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 5,
                            AttachmentUrl = "http://loren.org",
                            Content = "Ut et sed nostrum aut sed numquam.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 20, 32, 37, 451, DateTimeKind.Local).AddTicks(3720),
                            MessageType = 3,
                            ReceiverId = 6,
                            SenderId = 6,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 6,
                            AttachmentUrl = "https://leland.net",
                            Content = "Nemo rerum ut eos et.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 1, 42, 9, 142, DateTimeKind.Local).AddTicks(7914),
                            MessageType = 3,
                            ReceiverId = 3,
                            SenderId = 3,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 7,
                            AttachmentUrl = "https://clemmie.com",
                            Content = "Sed quibusdam reiciendis illum illum aut dolorem qui omnis.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 14, 24, 1, 377, DateTimeKind.Local).AddTicks(2150),
                            MessageType = 2,
                            ReceiverId = 9,
                            SenderId = 2,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 8,
                            AttachmentUrl = "http://elliott.net",
                            Content = "Fuga ea quibusdam sunt veritatis et.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 16, 49, 38, 835, DateTimeKind.Local).AddTicks(3881),
                            MessageType = 3,
                            ReceiverId = 1,
                            SenderId = 8,
                            isRead = false,
                            isSent = false
                        },
                        new
                        {
                            Id = 9,
                            AttachmentUrl = "https://jules.com",
                            Content = "Omnis odio sed quisquam occaecati officia harum.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 9, 1, 33, 279, DateTimeKind.Local).AddTicks(6754),
                            MessageType = 2,
                            ReceiverId = 9,
                            SenderId = 4,
                            isRead = false,
                            isSent = false
                        },
                        new
                        {
                            Id = 10,
                            AttachmentUrl = "https://winfield.com",
                            Content = "Quo repellat voluptate possimus.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 20, 49, 49, 459, DateTimeKind.Local).AddTicks(7599),
                            MessageType = 2,
                            ReceiverId = 2,
                            SenderId = 8,
                            isRead = false,
                            isSent = false
                        },
                        new
                        {
                            Id = 11,
                            AttachmentUrl = "http://taya.biz",
                            Content = "Cupiditate hic nihil.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 8, 24, 37, 865, DateTimeKind.Local).AddTicks(5210),
                            MessageType = 3,
                            ReceiverId = 10,
                            SenderId = 4,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 12,
                            AttachmentUrl = "http://aileen.biz",
                            Content = "Quidem omnis molestiae.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 2, 20, 57, 936, DateTimeKind.Local).AddTicks(6949),
                            MessageType = 1,
                            ReceiverId = 7,
                            SenderId = 1,
                            isRead = true,
                            isSent = true
                        },
                        new
                        {
                            Id = 13,
                            AttachmentUrl = "https://rod.info",
                            Content = "Est expedita aliquam ipsa possimus praesentium alias explicabo.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 1, 9, 26, 339, DateTimeKind.Local).AddTicks(8406),
                            MessageType = 2,
                            ReceiverId = 4,
                            SenderId = 3,
                            isRead = true,
                            isSent = true
                        },
                        new
                        {
                            Id = 14,
                            AttachmentUrl = "http://baylee.name",
                            Content = "Fugiat ut modi architecto expedita aperiam adipisci consequatur autem.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 2, 26, 21, 935, DateTimeKind.Local).AddTicks(1557),
                            MessageType = 1,
                            ReceiverId = 9,
                            SenderId = 10,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 15,
                            AttachmentUrl = "http://alf.biz",
                            Content = "Dignissimos quae perspiciatis omnis incidunt omnis fuga.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 22, 10, 45, 626, DateTimeKind.Local).AddTicks(2502),
                            MessageType = 3,
                            ReceiverId = 5,
                            SenderId = 5,
                            isRead = false,
                            isSent = true
                        },
                        new
                        {
                            Id = 16,
                            AttachmentUrl = "http://dario.name",
                            Content = "Mollitia consequatur natus qui et neque natus.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 14, 10, 21, 233, DateTimeKind.Local).AddTicks(2761),
                            MessageType = 1,
                            ReceiverId = 4,
                            SenderId = 8,
                            isRead = false,
                            isSent = false
                        },
                        new
                        {
                            Id = 17,
                            AttachmentUrl = "https://ashlynn.net",
                            Content = "Eligendi ducimus nulla debitis velit dicta maxime porro qui.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 14, 41, 45, 247, DateTimeKind.Local).AddTicks(8755),
                            MessageType = 1,
                            ReceiverId = 1,
                            SenderId = 9,
                            isRead = true,
                            isSent = false
                        },
                        new
                        {
                            Id = 18,
                            AttachmentUrl = "https://wilbert.net",
                            Content = "Quam vel eius temporibus corporis doloremque voluptatem recusandae molestiae et.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 10, 41, 6, 766, DateTimeKind.Local).AddTicks(1689),
                            MessageType = 2,
                            ReceiverId = 5,
                            SenderId = 6,
                            isRead = false,
                            isSent = true
                        },
                        new
                        {
                            Id = 19,
                            AttachmentUrl = "http://frida.biz",
                            Content = "Repudiandae impedit eos modi alias recusandae dolorem ut.",
                            IsDeleted = true,
                            MessageDate = new DateTime(2023, 12, 21, 11, 31, 3, 271, DateTimeKind.Local).AddTicks(1690),
                            MessageType = 0,
                            ReceiverId = 6,
                            SenderId = 1,
                            isRead = false,
                            isSent = false
                        },
                        new
                        {
                            Id = 20,
                            AttachmentUrl = "https://lula.biz",
                            Content = "Assumenda consequatur quis perspiciatis fugiat a.",
                            IsDeleted = false,
                            MessageDate = new DateTime(2023, 12, 21, 10, 2, 25, 921, DateTimeKind.Local).AddTicks(6798),
                            MessageType = 2,
                            ReceiverId = 6,
                            SenderId = 3,
                            isRead = false,
                            isSent = true
                        });
                });

            modelBuilder.Entity("LiveChat.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Justin.Konopelski64@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=348",
                            Name = "Justin Konopelski",
                            Password = "sk41HzFizN",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Zachary_Howe77@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=1078",
                            Name = "Zachary Howe",
                            Password = "6U65Y1WAR0",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Dan.Shields@hotmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=523",
                            Name = "Dan Shields",
                            Password = "yBwGanBPtC",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Jeremiah.Gislason@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=166",
                            Name = "Jeremiah Gislason",
                            Password = "O4a2SPEVMk",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Mitchell85@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=575",
                            Name = "Mitchell Parker",
                            Password = "Le9MWKvg3a",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 6,
                            Email = "Shari47@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=491",
                            Name = "Shari Morar",
                            Password = "bdvKpioDAY",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = 7,
                            Email = "Victoria.Rath37@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=776",
                            Name = "Victoria Rath",
                            Password = "ygYCezOcEe",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 8,
                            Email = "Calvin_Anderson@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=281",
                            Name = "Calvin Anderson",
                            Password = "bKQbjLiZka",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 9,
                            Email = "Rudolph.McKenzie35@hotmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=543",
                            Name = "Rudolph McKenzie",
                            Password = "VNHZzd1MfZ",
                            UserType = "User"
                        },
                        new
                        {
                            Id = 10,
                            Email = "Opal_Boehm62@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=363",
                            Name = "Opal Boehm",
                            Password = "_dkeqMsa8V",
                            UserType = "Admin"
                        });
                });

            modelBuilder.Entity("LiveChat.API.Models.UserConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserConnections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConnectionId = "50f0bc8b-099c-e61a-5f56-c571a1badfb4",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            ConnectionId = "f31ce4e6-405b-a884-2daa-99281286bbb7",
                            UserId = 9
                        },
                        new
                        {
                            Id = 3,
                            ConnectionId = "5592dc29-6810-1bfe-1c1f-a97be8cebda0",
                            UserId = 6
                        },
                        new
                        {
                            Id = 4,
                            ConnectionId = "d7179e82-7b30-a76c-6e5e-81be4dcf0aba",
                            UserId = 8
                        },
                        new
                        {
                            Id = 5,
                            ConnectionId = "1c220390-7cd5-d81e-3e20-da2d44dbdb88",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("LiveChat.API.Models.Message", b =>
                {
                    b.HasOne("LiveChat.API.Models.User", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LiveChat.API.Models.User", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("LiveChat.API.Models.UserConnection", b =>
                {
                    b.HasOne("LiveChat.API.Models.User", "User")
                        .WithMany("UserConnections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LiveChat.API.Models.User", b =>
                {
                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");

                    b.Navigation("UserConnections");
                });
#pragma warning restore 612, 618
        }
    }
}
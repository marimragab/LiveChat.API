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
    [Migration("20231221225357_edit2")]
    partial class edit2
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
                            MessageDate = new DateTime(2023, 12, 21, 19, 5, 13, 576, DateTimeKind.Local).AddTicks(4935),
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
                            MessageDate = new DateTime(2023, 12, 21, 12, 3, 16, 94, DateTimeKind.Local).AddTicks(8821),
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
                            MessageDate = new DateTime(2023, 12, 21, 9, 59, 58, 397, DateTimeKind.Local).AddTicks(2722),
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
                            MessageDate = new DateTime(2023, 12, 21, 3, 58, 27, 195, DateTimeKind.Local).AddTicks(9528),
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
                            MessageDate = new DateTime(2023, 12, 21, 20, 38, 50, 970, DateTimeKind.Local).AddTicks(3388),
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
                            MessageDate = new DateTime(2023, 12, 21, 1, 48, 22, 661, DateTimeKind.Local).AddTicks(7638),
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
                            MessageDate = new DateTime(2023, 12, 21, 14, 30, 14, 896, DateTimeKind.Local).AddTicks(1916),
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
                            MessageDate = new DateTime(2023, 12, 21, 16, 55, 52, 354, DateTimeKind.Local).AddTicks(3676),
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
                            MessageDate = new DateTime(2023, 12, 21, 9, 7, 46, 798, DateTimeKind.Local).AddTicks(6573),
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
                            MessageDate = new DateTime(2023, 12, 21, 20, 56, 2, 978, DateTimeKind.Local).AddTicks(7427),
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
                            MessageDate = new DateTime(2023, 12, 21, 8, 30, 51, 384, DateTimeKind.Local).AddTicks(5046),
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
                            MessageDate = new DateTime(2023, 12, 21, 2, 27, 11, 455, DateTimeKind.Local).AddTicks(6765),
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
                            MessageDate = new DateTime(2023, 12, 21, 1, 15, 39, 858, DateTimeKind.Local).AddTicks(8231),
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
                            MessageDate = new DateTime(2023, 12, 21, 2, 32, 35, 454, DateTimeKind.Local).AddTicks(1380),
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
                            MessageDate = new DateTime(2023, 12, 21, 22, 16, 59, 145, DateTimeKind.Local).AddTicks(2317),
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
                            MessageDate = new DateTime(2023, 12, 21, 14, 16, 34, 752, DateTimeKind.Local).AddTicks(2472),
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
                            MessageDate = new DateTime(2023, 12, 21, 14, 47, 58, 766, DateTimeKind.Local).AddTicks(8645),
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
                            MessageDate = new DateTime(2023, 12, 21, 10, 47, 20, 285, DateTimeKind.Local).AddTicks(1580),
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
                            MessageDate = new DateTime(2023, 12, 21, 11, 37, 16, 790, DateTimeKind.Local).AddTicks(1586),
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
                            MessageDate = new DateTime(2023, 12, 21, 10, 8, 39, 440, DateTimeKind.Local).AddTicks(6832),
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

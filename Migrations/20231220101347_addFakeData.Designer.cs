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
    [Migration("20231220101347_addFakeData")]
    partial class addFakeData
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

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.Property<bool>("Read")
                        .HasColumnType("bit");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sended")
                        .HasColumnType("datetime2");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AttachmentUrl = "http://jackie.net",
                            Content = "Beatae veniam magni iusto voluptatem provident incidunt saepe aut non.",
                            IsDeleted = false,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -7,
                            Sended = new DateTime(2023, 12, 20, 6, 25, 3, 879, DateTimeKind.Local).AddTicks(9145),
                            SenderId = -2
                        },
                        new
                        {
                            Id = -2,
                            AttachmentUrl = "http://katlynn.com",
                            Content = "Consequatur aut quos dolorem illo qui sed occaecati.",
                            IsDeleted = false,
                            MessageType = 2,
                            Read = true,
                            ReceiverId = -7,
                            Sended = new DateTime(2023, 12, 20, 11, 44, 35, 461, DateTimeKind.Local).AddTicks(4882),
                            SenderId = -1
                        },
                        new
                        {
                            Id = -3,
                            AttachmentUrl = "http://ashleigh.biz",
                            Content = "Mollitia dolores dolor fugiat nobis.",
                            IsDeleted = false,
                            MessageType = 1,
                            Read = false,
                            ReceiverId = -4,
                            Sended = new DateTime(2023, 12, 19, 23, 49, 59, 23, DateTimeKind.Local).AddTicks(4796),
                            SenderId = -6
                        },
                        new
                        {
                            Id = -4,
                            AttachmentUrl = "http://nels.com",
                            Content = "Distinctio excepturi odit autem nemo eum et repellat.",
                            IsDeleted = false,
                            MessageType = 2,
                            Read = true,
                            ReceiverId = -5,
                            Sended = new DateTime(2023, 12, 19, 19, 5, 3, 132, DateTimeKind.Local).AddTicks(3437),
                            SenderId = -4
                        },
                        new
                        {
                            Id = -5,
                            AttachmentUrl = "http://cristopher.biz",
                            Content = "Nemo deserunt ut et.",
                            IsDeleted = true,
                            MessageType = 1,
                            Read = false,
                            ReceiverId = -6,
                            Sended = new DateTime(2023, 12, 19, 23, 24, 26, 582, DateTimeKind.Local).AddTicks(3605),
                            SenderId = -3
                        },
                        new
                        {
                            Id = -6,
                            AttachmentUrl = "http://sheridan.org",
                            Content = "Harum fugiat necessitatibus.",
                            IsDeleted = false,
                            MessageType = 0,
                            Read = true,
                            ReceiverId = -10,
                            Sended = new DateTime(2023, 12, 19, 23, 25, 46, 240, DateTimeKind.Local).AddTicks(5609),
                            SenderId = -1
                        },
                        new
                        {
                            Id = -7,
                            AttachmentUrl = "http://paris.com",
                            Content = "Voluptatem accusamus facere id.",
                            IsDeleted = false,
                            MessageType = 3,
                            Read = true,
                            ReceiverId = -9,
                            Sended = new DateTime(2023, 12, 19, 17, 46, 23, 463, DateTimeKind.Local).AddTicks(9826),
                            SenderId = -10
                        },
                        new
                        {
                            Id = -8,
                            AttachmentUrl = "http://shayna.info",
                            Content = "Aut dolorem qui omnis et corporis eum error sint.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -8,
                            Sended = new DateTime(2023, 12, 20, 7, 33, 51, 377, DateTimeKind.Local).AddTicks(8630),
                            SenderId = -5
                        },
                        new
                        {
                            Id = -9,
                            AttachmentUrl = "https://aurelio.name",
                            Content = "Veritatis et sit laudantium sunt soluta ducimus.",
                            IsDeleted = false,
                            MessageType = 3,
                            Read = false,
                            ReceiverId = -3,
                            Sended = new DateTime(2023, 12, 20, 4, 56, 3, 343, DateTimeKind.Local).AddTicks(8456),
                            SenderId = -5
                        },
                        new
                        {
                            Id = -10,
                            AttachmentUrl = "http://ryan.com",
                            Content = "Occaecati officia harum expedita nulla possimus tenetur iste.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -5,
                            Sended = new DateTime(2023, 12, 19, 23, 37, 4, 32, DateTimeKind.Local).AddTicks(6897),
                            SenderId = -10
                        },
                        new
                        {
                            Id = -11,
                            AttachmentUrl = "https://maynard.net",
                            Content = "Dolorem est nihil debitis accusamus maiores alias deserunt porro.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -9,
                            Sended = new DateTime(2023, 12, 20, 7, 26, 34, 236, DateTimeKind.Local).AddTicks(3006),
                            SenderId = -2
                        },
                        new
                        {
                            Id = -12,
                            AttachmentUrl = "https://tiara.org",
                            Content = "Repudiandae eius saepe autem.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -1,
                            Sended = new DateTime(2023, 12, 19, 14, 31, 59, 707, DateTimeKind.Local).AddTicks(8497),
                            SenderId = -1
                        },
                        new
                        {
                            Id = -13,
                            AttachmentUrl = "https://deondre.com",
                            Content = "Sit ad et perferendis.",
                            IsDeleted = false,
                            MessageType = 3,
                            Read = false,
                            ReceiverId = -1,
                            Sended = new DateTime(2023, 12, 19, 20, 51, 48, 30, DateTimeKind.Local).AddTicks(4898),
                            SenderId = -5
                        },
                        new
                        {
                            Id = -14,
                            AttachmentUrl = "http://kali.biz",
                            Content = "Maiores optio nesciunt.",
                            IsDeleted = false,
                            MessageType = 1,
                            Read = false,
                            ReceiverId = -9,
                            Sended = new DateTime(2023, 12, 20, 10, 50, 21, 189, DateTimeKind.Local).AddTicks(3617),
                            SenderId = -9
                        },
                        new
                        {
                            Id = -15,
                            AttachmentUrl = "https://hershel.biz",
                            Content = "Modi architecto expedita aperiam.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = true,
                            ReceiverId = -2,
                            Sended = new DateTime(2023, 12, 20, 7, 31, 51, 652, DateTimeKind.Local).AddTicks(7931),
                            SenderId = -5
                        },
                        new
                        {
                            Id = -16,
                            AttachmentUrl = "https://bernardo.biz",
                            Content = "Quaerat sapiente at dolorum dignissimos quae perspiciatis.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -1,
                            Sended = new DateTime(2023, 12, 19, 17, 36, 40, 238, DateTimeKind.Local).AddTicks(2429),
                            SenderId = -5
                        },
                        new
                        {
                            Id = -17,
                            AttachmentUrl = "http://keenan.info",
                            Content = "Numquam consequatur deleniti.",
                            IsDeleted = false,
                            MessageType = 2,
                            Read = false,
                            ReceiverId = -6,
                            Sended = new DateTime(2023, 12, 20, 2, 0, 57, 63, DateTimeKind.Local).AddTicks(5668),
                            SenderId = -2
                        },
                        new
                        {
                            Id = -18,
                            AttachmentUrl = "https://matt.info",
                            Content = "Rem deserunt autem quia incidunt in.",
                            IsDeleted = false,
                            MessageType = 3,
                            Read = true,
                            ReceiverId = -5,
                            Sended = new DateTime(2023, 12, 20, 2, 12, 14, 335, DateTimeKind.Local).AddTicks(6636),
                            SenderId = -9
                        },
                        new
                        {
                            Id = -19,
                            AttachmentUrl = "https://lindsay.com",
                            Content = "Maxime porro qui.",
                            IsDeleted = true,
                            MessageType = 2,
                            Read = true,
                            ReceiverId = -9,
                            Sended = new DateTime(2023, 12, 20, 2, 7, 49, 69, DateTimeKind.Local).AddTicks(2348),
                            SenderId = -4
                        },
                        new
                        {
                            Id = -20,
                            AttachmentUrl = "http://emiliano.org",
                            Content = "Asperiores quam vel.",
                            IsDeleted = false,
                            MessageType = 1,
                            Read = true,
                            ReceiverId = -6,
                            Sended = new DateTime(2023, 12, 20, 7, 0, 49, 167, DateTimeKind.Local).AddTicks(8181),
                            SenderId = -10
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

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Email = "Justin.Konopelski64@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=348",
                            Name = "Justin Konopelski",
                            Password = "sk41HzFizN",
                            UserType = 0
                        },
                        new
                        {
                            Id = -2,
                            Email = "Zachary_Howe77@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=1078",
                            Name = "Zachary Howe",
                            Password = "6U65Y1WAR0",
                            UserType = 1
                        },
                        new
                        {
                            Id = -3,
                            Email = "Dan.Shields@hotmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=523",
                            Name = "Dan Shields",
                            Password = "yBwGanBPtC",
                            UserType = 1
                        },
                        new
                        {
                            Id = -4,
                            Email = "Jeremiah.Gislason@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=166",
                            Name = "Jeremiah Gislason",
                            Password = "O4a2SPEVMk",
                            UserType = 0
                        },
                        new
                        {
                            Id = -5,
                            Email = "Mitchell85@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=575",
                            Name = "Mitchell Parker",
                            Password = "Le9MWKvg3a",
                            UserType = 1
                        },
                        new
                        {
                            Id = -6,
                            Email = "Shari47@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=491",
                            Name = "Shari Morar",
                            Password = "bdvKpioDAY",
                            UserType = 0
                        },
                        new
                        {
                            Id = -7,
                            Email = "Victoria.Rath37@gmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=776",
                            Name = "Victoria Rath",
                            Password = "ygYCezOcEe",
                            UserType = 1
                        },
                        new
                        {
                            Id = -8,
                            Email = "Calvin_Anderson@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=281",
                            Name = "Calvin Anderson",
                            Password = "bKQbjLiZka",
                            UserType = 1
                        },
                        new
                        {
                            Id = -9,
                            Email = "Rudolph.McKenzie35@hotmail.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=543",
                            Name = "Rudolph McKenzie",
                            Password = "VNHZzd1MfZ",
                            UserType = 1
                        },
                        new
                        {
                            Id = -10,
                            Email = "Opal_Boehm62@yahoo.com",
                            ImageUrl = "https://picsum.photos/640/480/?image=363",
                            Name = "Opal Boehm",
                            Password = "_dkeqMsa8V",
                            UserType = 0
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
                            Id = -1,
                            ConnectionId = "6f365c04-3777-9217-5635-f5d7b6f395b7",
                            UserId = -2
                        },
                        new
                        {
                            Id = -2,
                            ConnectionId = "eecf7d36-eb3e-b594-9883-a5ac7118027c",
                            UserId = -9
                        },
                        new
                        {
                            Id = -3,
                            ConnectionId = "888aec6e-549d-68bc-8334-cb8bbcf0509c",
                            UserId = -2
                        },
                        new
                        {
                            Id = -4,
                            ConnectionId = "565fe61a-71c5-baa1-dfb4-72e6e41cf35b",
                            UserId = -4
                        },
                        new
                        {
                            Id = -5,
                            ConnectionId = "aa2da884-2899-8612-bbb7-c829dc925510",
                            UserId = -7
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
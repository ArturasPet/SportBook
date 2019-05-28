﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportBook.Models;

namespace SportBook.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190528181612_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportBook.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreationTime");

                    b.Property<string>("EventName");

                    b.Property<bool>("HasStarted");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("StartTime");

                    b.Property<string>("State");

                    b.Property<string>("Type");

                    b.Property<int>("UserId");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SportBook.Models.Invitation", b =>
                {
                    b.Property<int>("InvitationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId");

                    b.Property<int>("TeamId");

                    b.Property<string>("Text");

                    b.Property<int>("UserId");

                    b.HasKey("InvitationId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("SportBook.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<string>("Text");

                    b.HasKey("MessageId");

                    b.HasIndex("EventId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SportBook.Models.ParticipantList", b =>
                {
                    b.Property<int>("ParticipantListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("ParticipantListId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("ParticipantLists");
                });

            modelBuilder.Entity("SportBook.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName");

                    b.Property<int>("Type");

                    b.Property<int>("UserId");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SportBook.Models.TeamMembers", b =>
                {
                    b.Property<int>("TeamMembersId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TeamId");

                    b.Property<int>("UserId");

                    b.HasKey("TeamMembersId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("SportBook.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Game_account");

                    b.Property<string>("Nickname");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SportBook.Models.Invitation", b =>
                {
                    b.HasOne("SportBook.Models.Event")
                        .WithMany("Invitations")
                        .HasForeignKey("EventId");

                    b.HasOne("SportBook.Models.User")
                        .WithMany("Invitations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportBook.Models.Message", b =>
                {
                    b.HasOne("SportBook.Models.Event")
                        .WithMany("Messages")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportBook.Models.ParticipantList", b =>
                {
                    b.HasOne("SportBook.Models.Event")
                        .WithMany("ParticipantList")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportBook.Models.User")
                        .WithMany("ParticipantList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportBook.Models.TeamMembers", b =>
                {
                    b.HasOne("SportBook.Models.Team")
                        .WithMany("TeamMembers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportBook.Models.User")
                        .WithMany("TeamMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
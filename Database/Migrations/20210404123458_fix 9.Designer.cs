﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210404123458_fix 9")]
    partial class fix9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.2.21154.2")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Database.Link.LinkModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Href");

                    b.Property<string>("IconName")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("IconName");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Subtitle");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Title");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId1")
                        .HasColumnType("integer");

                    b.Property<int>("UserModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Database.User.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Email");

                    b.Property<List<long>>("LinkIds")
                        .IsRequired()
                        .HasColumnType("bigint[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Password");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ProfileImagePath");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Database.Link.LinkModel", b =>
                {
                    b.HasOne("Database.User.UserModel", null)
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.User.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Database.User.UserModel", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}

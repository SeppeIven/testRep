﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pencil42App.Web.Repositories;

namespace Pencil42App.Web.Migrations
{
    [DbContext(typeof(App42Context))]
    [Migration("20190930111641_userid")]
    partial class userid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Pencil42App.Web.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DayOfWeek");

                    b.Property<string>("Description");

                    b.Property<int>("Kind");

                    b.Property<string>("Milestone");

                    b.Property<double>("NumberOfHours");

                    b.Property<int>("Type");

                    b.Property<int>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.Suggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Kind");

                    b.Property<string>("Milestone");

                    b.Property<string>("Name");

                    b.Property<double>("NumberOfHours");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Suggestion");
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HoursToWorkInAWeek");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool[]>("CompleteDays");

                    b.Property<double>("HoursWorked");

                    b.Property<string>("UserId");

                    b.Property<int>("WeekNumber");

                    b.Property<bool>("Week_complete");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Week");
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.Booking", b =>
                {
                    b.HasOne("Pencil42App.Web.Entities.Week")
                        .WithMany("Bookings")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.Suggestion", b =>
                {
                    b.HasOne("Pencil42App.Web.Entities.User")
                        .WithMany("Suggestions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Pencil42App.Web.Entities.Week", b =>
                {
                    b.HasOne("Pencil42App.Web.Entities.User")
                        .WithMany("Weeks")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

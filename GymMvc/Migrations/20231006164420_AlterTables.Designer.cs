﻿// <auto-generated />
using System;
using GymMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231006164420_AlterTables")]
    partial class AlterTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymMvc.Models.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Age")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone Number");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("years_of_experience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Information");
                });

            modelBuilder.Entity("GymMvc.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InformationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InformationId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("GymMvc.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Approve")
                        .HasColumnType("bit");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Sent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("GymMvc.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoacheId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("GymMvc.Models.ScheduleWorkOut", b =>
                {
                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkOutId")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId", "WorkOutId");

                    b.HasIndex("WorkOutId");

                    b.ToTable("ScheduleWorkOuts");
                });

            modelBuilder.Entity("GymMvc.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "coache"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tranier"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("GymMvc.Models.WorkOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkOuts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "dumbbell-bench-press.jpg",
                            Name = "dumbbell bench press"
                        },
                        new
                        {
                            Id = 2,
                            Image = "seated-chest-press.jpg",
                            Name = "seated chest press"
                        },
                        new
                        {
                            Id = 3,
                            Image = "how-to-shoulder-press-mchine.jpg",
                            Name = "seated shoulder press machine"
                        },
                        new
                        {
                            Id = 4,
                            Image = "tricep-pushdown.png",
                            Name = "tricep pushdown"
                        },
                        new
                        {
                            Id = 5,
                            Image = "latpulldownimage.jpg",
                            Name = "lat pulldown"
                        },
                        new
                        {
                            Id = 6,
                            Image = "barbell-row.png",
                            Name = "barbell bent over row"
                        },
                        new
                        {
                            Id = 7,
                            Image = "chest-supported-row.jpg",
                            Name = "incline dumbbell row, or chest supported row"
                        },
                        new
                        {
                            Id = 8,
                            Image = "seated-rear-delt-fly.png",
                            Name = "Face pulls"
                        },
                        new
                        {
                            Id = 9,
                            Image = "bicep.jpg",
                            Name = "bicep curl"
                        },
                        new
                        {
                            Id = 10,
                            Image = "squat-2x.jpg",
                            Name = "Squats"
                        },
                        new
                        {
                            Id = 11,
                            Image = "leg-press.jpg",
                            Name = "leg press"
                        },
                        new
                        {
                            Id = 12,
                            Image = "leg-curl.png",
                            Name = "Hamstring curls"
                        },
                        new
                        {
                            Id = 13,
                            Image = "lunge-2x.jpg",
                            Name = "lunge"
                        },
                        new
                        {
                            Id = 14,
                            Image = "calf-raises.jpg",
                            Name = "calf raises"
                        },
                        new
                        {
                            Id = 15,
                            Image = "rear-delt-fly.jpg",
                            Name = "posterior deltoids"
                        });
                });

            modelBuilder.Entity("GymMvc.Models.Information", b =>
                {
                    b.HasOne("GymMvc.Models.User", "User")
                        .WithMany("information")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymMvc.Models.Login", b =>
                {
                    b.HasOne("GymMvc.Models.Information", "Information")
                        .WithOne("Login")
                        .HasForeignKey("GymMvc.Models.Login", "InformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymMvc.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Information");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymMvc.Models.ScheduleWorkOut", b =>
                {
                    b.HasOne("GymMvc.Models.Schedule", "Schedule")
                        .WithMany("WorkOuts")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymMvc.Models.WorkOut", "WorkOut")
                        .WithMany()
                        .HasForeignKey("WorkOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("WorkOut");
                });

            modelBuilder.Entity("GymMvc.Models.Information", b =>
                {
                    b.Navigation("Login")
                        .IsRequired();
                });

            modelBuilder.Entity("GymMvc.Models.Schedule", b =>
                {
                    b.Navigation("WorkOuts");
                });

            modelBuilder.Entity("GymMvc.Models.User", b =>
                {
                    b.Navigation("information");
                });
#pragma warning restore 612, 618
        }
    }
}
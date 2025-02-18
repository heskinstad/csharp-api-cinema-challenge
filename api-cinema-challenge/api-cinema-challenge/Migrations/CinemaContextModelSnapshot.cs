﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(3699),
                            Email = "chris@evans.com",
                            Name = "Chris Evans",
                            Phone = "11111111",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(3702)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4171),
                            Email = "chris@hemsworth.com",
                            Name = "Chris Hemsworth",
                            Phone = "22222222",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4171)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4172),
                            Email = "chris@pine.com",
                            Name = "Chris Pine",
                            Phone = "33333333",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4172)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4173),
                            Email = "chris@pratt.com",
                            Name = "Chris Pratt",
                            Phone = "44444444",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4174)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(7611),
                            Description = "WE HAVE TO GO DEEPER",
                            Rating = "Very good",
                            RuntimeMins = 150,
                            Title = "Inception",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(7611)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8105),
                            Description = "COME ON TARS",
                            Rating = "Very good",
                            RuntimeMins = 150,
                            Title = "Interstellar",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8105)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8107),
                            Description = "I HAVE BECOME DEATH",
                            Rating = "Very good",
                            RuntimeMins = 150,
                            Title = "Oppenheimer",
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8107)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 40,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8450),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8451)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 40,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8923),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8924)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 30,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8925),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2014, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8926)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 70,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8928),
                            MovieId = 3,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8928)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 80,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8929),
                            MovieId = 3,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8929)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("numSeats")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9189),
                            CustomerId = 1,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9189),
                            numSeats = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9448),
                            CustomerId = 1,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9448),
                            numSeats = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9450),
                            CustomerId = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9450),
                            numSeats = 4
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9451),
                            CustomerId = 2,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9451),
                            numSeats = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9452),
                            CustomerId = 3,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9452),
                            numSeats = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9453),
                            CustomerId = 4,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9453),
                            numSeats = 2
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}

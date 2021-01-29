﻿// <auto-generated />
using System;
using Benivo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Benivo.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BenivoProject.Domain.Core.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Jobid")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Jobid");

                    b.HasIndex("UserId");

                    b.ToTable("Bukmarks");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 19, DateTimeKind.Local).AddTicks(5669),
                            Deleted = false,
                            Name = "Software development"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(5484),
                            Deleted = false,
                            Name = "Quality Assurance"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(5499),
                            Deleted = false,
                            Name = "Web/Graphic design"
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(5501),
                            Deleted = false,
                            Name = "Product/Project Management"
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(5502),
                            Deleted = false,
                            Name = "Other IT"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Full Time"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Part Time"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Contractor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Intern"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Seasonal/Temp"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriId = 1,
                            Company = "Benivo",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(8647),
                            Deleted = false,
                            Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmploymentTypeId = 1,
                            Image = "/Images/Benivo.png",
                            LocationId = 1,
                            Title = "Senior Web developer"
                        },
                        new
                        {
                            Id = 2,
                            CategoriId = 2,
                            Company = "Google",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 21, DateTimeKind.Local).AddTicks(1603),
                            Deleted = false,
                            Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmploymentTypeId = 3,
                            Image = "/Images/Google.jpg",
                            LocationId = 2,
                            Title = "Quality developer"
                        },
                        new
                        {
                            Id = 3,
                            CategoriId = 3,
                            Company = "Benivo",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 21, DateTimeKind.Local).AddTicks(1608),
                            Deleted = false,
                            Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmploymentTypeId = 1,
                            Image = "/Images/Benivo.png",
                            LocationId = 2,
                            Title = "Design developer"
                        },
                        new
                        {
                            Id = 4,
                            CategoriId = 2,
                            Company = "Facebook",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 21, DateTimeKind.Local).AddTicks(1611),
                            Deleted = false,
                            Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmploymentTypeId = 2,
                            Image = "/Images/Facebook.png",
                            LocationId = 1,
                            Title = "Senior Quality developer"
                        },
                        new
                        {
                            Id = 5,
                            CategoriId = 1,
                            Company = "Benivo",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 21, DateTimeKind.Local).AddTicks(1613),
                            Deleted = false,
                            Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmploymentTypeId = 1,
                            Image = "/Images/Benivo.png",
                            LocationId = 1,
                            Title = "Web developer"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Country")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Region")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Armenia",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(5908),
                            Region = "Yerevan"
                        },
                        new
                        {
                            Id = 2,
                            City = "San Francisco",
                            Country = "US",
                            CreationDate = new DateTime(2021, 1, 29, 8, 50, 41, 20, DateTimeKind.Local).AddTicks(7248),
                            Region = "CA"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Password = "123456",
                            RoleId = 1,
                            UserName = "adminUserName"
                        });
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Bookmark", b =>
                {
                    b.HasOne("BenivoProject.Domain.Core.Job", "Job")
                        .WithMany("Bukmarks")
                        .HasForeignKey("Jobid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenivoProject.Domain.Core.User", "User")
                        .WithMany("Bukmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Job", b =>
                {
                    b.HasOne("BenivoProject.Domain.Core.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenivoProject.Domain.Core.EmploymentType", "EmploymentType")
                        .WithMany()
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenivoProject.Domain.Core.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("EmploymentType");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.User", b =>
                {
                    b.HasOne("BenivoProject.Domain.Core.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Job", b =>
                {
                    b.Navigation("Bukmarks");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BenivoProject.Domain.Core.User", b =>
                {
                    b.Navigation("Bukmarks");
                });
#pragma warning restore 612, 618
        }
    }
}

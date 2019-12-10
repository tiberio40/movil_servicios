﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movil.Models;

namespace Movil.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191210093425_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1baa10c2-1d15-4f27-a8f7-75a14e93c8a8",
                            ConcurrencyStamp = "a4143332-a251-494d-b185-9a05e6d5f750",
                            Name = "Usuario",
                            NormalizedName = "Usuario"
                        },
                        new
                        {
                            Id = "3c730730-0912-4922-aaee-9fc823a638ee",
                            ConcurrencyStamp = "add65f9c-c972-417f-a11f-c92f0c4d1f6d",
                            Name = "Profesor",
                            NormalizedName = "Profesor"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Movil.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Movil.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d985fed2-2ba0-443d-b8dc-1b5373d23b61"),
                            Name = "Matemáticas",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("9a2bf3a9-30f6-4fd3-8d7c-f858f1bb0885"),
                            Name = "Baile",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("f4f9d457-fd91-4d16-ba51-120115c50c09"),
                            Name = "Peluquería",
                            Status = true
                        });
                });

            modelBuilder.Entity("Movil.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Point");

                    b.Property<bool>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Movil.Models.CourseContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<Guid?>("CourseId");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("Movil.Models.CourseContentOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CourseContentId");

                    b.Property<Guid?>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("CourseContentId");

                    b.HasIndex("OrderId");

                    b.ToTable("CourseContentOrders");
                });

            modelBuilder.Entity("Movil.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("StudentId");

                    b.Property<string>("TeacherId");

                    b.Property<string>("status");

                    b.Property<int>("time");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Movil.Models.Owner", b =>
                {
                    b.Property<Guid>("OwnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("OwnerId");

                    b.ToTable("owner");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Movil.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Movil.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Movil.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Movil.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Movil.Models.Course", b =>
                {
                    b.HasOne("Movil.Models.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Movil.Models.AppUser", "User")
                        .WithMany("courses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Movil.Models.CourseContent", b =>
                {
                    b.HasOne("Movil.Models.Course", "Course")
                        .WithMany("CourseContent")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("Movil.Models.CourseContentOrder", b =>
                {
                    b.HasOne("Movil.Models.CourseContent", "CourseContent")
                        .WithMany("CourseContentOrders")
                        .HasForeignKey("CourseContentId");

                    b.HasOne("Movil.Models.Order", "Order")
                        .WithMany("CourseContentOrders")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Movil.Models.Order", b =>
                {
                    b.HasOne("Movil.Models.AppUser", "Student")
                        .WithMany("Orders")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Movil.Models.AppUser", "Teacher")
                        .WithMany("TeacherOrders")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webonline.Data.EF;

namespace Webonline.Data.Migrations
{
    [DbContext(typeof(SchoolDbConnect))]
    [Migration("20210114020728_create")]
    partial class create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"),
                            RoleId = new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken");
                });

            modelBuilder.Entity("Webonline.Data.EF.Khoa", b =>
                {
                    b.Property<int>("IdKhoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KhoaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasColumnName("TenKhoa")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdKhoa");

                    b.ToTable("Khoa");

                    b.HasData(
                        new
                        {
                            IdKhoa = 123,
                            KhoaID = 0,
                            TenKhoa = "KhoaCNTT"
                        },
                        new
                        {
                            IdKhoa = 124,
                            KhoaID = 0,
                            TenKhoa = "KhoaCNSinhHoc"
                        },
                        new
                        {
                            IdKhoa = 125,
                            KhoaID = 0,
                            TenKhoa = "KhoaHoa"
                        });
                });

            modelBuilder.Entity("Webonline.Data.EF.MonHoc", b =>
                {
                    b.Property<int>("ID_Mon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten_MH")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID_Mon");

                    b.ToTable("MonHoc");

                    b.HasData(
                        new
                        {
                            ID_Mon = 345,
                            Ten_MH = "Toan"
                        },
                        new
                        {
                            ID_Mon = 245,
                            Ten_MH = "Van"
                        },
                        new
                        {
                            ID_Mon = 145,
                            Ten_MH = "Hoa"
                        });
                });

            modelBuilder.Entity("Webonline.Data.EF.SinhVien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdKhoa")
                        .HasColumnType("int");

                    b.Property<string>("MaSV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("viewCout")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.HasIndex("IdKhoa");

                    b.ToTable("SinhVien");

                    b.HasData(
                        new
                        {
                            id = 1,
                            IdKhoa = 123,
                            MaSV = "12345",
                            Name = "Danh",
                            UserID = new Guid("00000000-0000-0000-0000-000000000000"),
                            viewCout = 1
                        },
                        new
                        {
                            id = 2,
                            IdKhoa = 124,
                            MaSV = "123456",
                            Name = "Nam",
                            UserID = new Guid("00000000-0000-0000-0000-000000000000"),
                            viewCout = 2
                        },
                        new
                        {
                            id = 3,
                            IdKhoa = 123,
                            MaSV = "1234",
                            Name = "Hung",
                            UserID = new Guid("00000000-0000-0000-0000-000000000000"),
                            viewCout = 3
                        });
                });

            modelBuilder.Entity("Webonline.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3"),
                            ConcurrencyStamp = "2b809757-7eb6-434f-b861-a2eeb578511f",
                            Description = "Adminstrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Webonline.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3323de48-8a47-400d-aa0e-fffd9bfc5f1c",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "XuanDanh@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "xuandanh@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEKL24j8TX8JxCIAmUmeHr592V3168F0dBL4WGu1oUj6w2HWKY8+0EzLpyrXzoSkugg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            firstname = "Xuan",
                            lastname = "Danh"
                        });
                });

            modelBuilder.Entity("Webonline.Data.Entities.MonHocKhoa", b =>
                {
                    b.Property<int>("KhoaID")
                        .HasColumnType("int");

                    b.Property<int>("MonhocID")
                        .HasColumnType("int");

                    b.HasKey("KhoaID", "MonhocID");

                    b.HasIndex("MonhocID");

                    b.ToTable("MonHocKhoa");
                });

            modelBuilder.Entity("Webonline.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateIma")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileSize")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<bool>("Isdefault")
                        .HasColumnType("bit");

                    b.Property<int>("SortImage")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("productID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Webonline.Data.Entities.Sinh_Mon", b =>
                {
                    b.Property<int>("Id_Mon")
                        .HasColumnType("int");

                    b.Property<int>("SinhvienId")
                        .HasColumnType("int");

                    b.HasKey("Id_Mon", "SinhvienId");

                    b.HasIndex("SinhvienId");

                    b.ToTable("MonHocSinhVien");

                    b.HasData(
                        new
                        {
                            Id_Mon = 345,
                            SinhvienId = 1
                        },
                        new
                        {
                            Id_Mon = 345,
                            SinhvienId = 2
                        },
                        new
                        {
                            Id_Mon = 345,
                            SinhvienId = 3
                        });
                });

            modelBuilder.Entity("Webonline.Data.EF.SinhVien", b =>
                {
                    b.HasOne("Webonline.Data.EF.Khoa", "Khoa")
                        .WithMany("SinhViens")
                        .HasForeignKey("IdKhoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webonline.Data.Entities.MonHocKhoa", b =>
                {
                    b.HasOne("Webonline.Data.EF.Khoa", "Khoa")
                        .WithMany("MonHocKhoa")
                        .HasForeignKey("KhoaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webonline.Data.EF.MonHoc", "monHoc")
                        .WithMany("MonHocKhoa")
                        .HasForeignKey("MonhocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webonline.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("Webonline.Data.Entities.AppUser", null)
                        .WithMany("productImages")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Webonline.Data.EF.SinhVien", "sinhVien")
                        .WithMany("productImages")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webonline.Data.Entities.Sinh_Mon", b =>
                {
                    b.HasOne("Webonline.Data.EF.MonHoc", "MonHoc")
                        .WithMany("SinhMon")
                        .HasForeignKey("Id_Mon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webonline.Data.EF.SinhVien", "SinhVien")
                        .WithMany("SinhMon")
                        .HasForeignKey("SinhvienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

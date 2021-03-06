// <auto-generated />
using System;
using KhoaLuanTotNghiep.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.News", b =>
                {
                    b.Property<string>("NewsID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NewsID");

                    b.HasIndex("UserID");

                    b.ToTable("news");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RealestateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("AdminId");

                    b.HasIndex("RealestateId")
                        .IsUnique()
                        .HasFilter("[RealestateId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Rates", b =>
                {
                    b.Property<int>("IDRate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RealEstateID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("IDRate");

                    b.ToTable("rates");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.RealEstate", b =>
                {
                    b.Property<string>("RealEstateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Acgreage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Approve")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RealEstateID");

                    b.HasIndex("AdminID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("realEstates");

                    b.HasData(
                        new
                        {
                            RealEstateID = "fd1781db-344d-4a9d-adef-abaf4d9bca6e",
                            Acgreage = "95",
                            AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                            Approve = false,
                            CategoryID = "1",
                            CreateTime = new DateTime(2021, 12, 26, 21, 24, 49, 700, DateTimeKind.Local).AddTicks(6803),
                            Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                            Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                            Location = "50 Lê Lợi",
                            Price = "19 tỷ",
                            Status = 0,
                            Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                            UpdateTime = new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2454),
                            UserID = "98f56474-6dee-4c27-96c0-73cc20149b89"
                        },
                        new
                        {
                            RealEstateID = "c63f7e1e-2178-4f56-9774-8c11bde5bfab",
                            Acgreage = "95",
                            AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                            Approve = false,
                            CategoryID = "1",
                            CreateTime = new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2920),
                            Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                            Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                            Location = "50 Lê Lợi",
                            Price = "19 tỷ",
                            Status = 0,
                            Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                            UpdateTime = new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2924),
                            UserID = "98f56474-6dee-4c27-96c0-73cc20149b89"
                        },
                        new
                        {
                            RealEstateID = "40e9efbf-0437-4e15-95fc-82ee37208ebb",
                            Acgreage = "95",
                            AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                            Approve = false,
                            CategoryID = "2",
                            CreateTime = new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2933),
                            Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                            Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png",
                            Location = "50 Lê Lợi",
                            Price = "19 tỷ",
                            Status = 0,
                            Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                            UpdateTime = new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2934),
                            UserID = "98f56474-6dee-4c27-96c0-73cc20149b89"
                        });
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Report", b =>
                {
                    b.Property<string>("ReportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreaeTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealEstateID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ReportID");

                    b.HasIndex("RealEstateID");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Transaction", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Profit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealEstateID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("transactions");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("ChangePassword")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalaryBasic")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.News", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", "user")
                        .WithMany("news")
                        .HasForeignKey("UserID");

                    b.Navigation("user");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Order", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", "admin")
                        .WithMany("orderIdAdmin")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.RealEstate", "realEstate")
                        .WithOne("order")
                        .HasForeignKey("KhoaLuanTotNghiep_BackEnd.Models.Order", "RealestateId");

                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", "user")
                        .WithMany("orderIdUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("admin");

                    b.Navigation("realEstate");

                    b.Navigation("user");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.RealEstate", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", "admin")
                        .WithMany("RealEstateIdAdmin")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.Category", "category")
                        .WithMany("RealEstates")
                        .HasForeignKey("CategoryID");

                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", "user")
                        .WithMany("RealEstateIdUser")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("admin");

                    b.Navigation("category");

                    b.Navigation("user");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Report", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.RealEstate", "realEstates")
                        .WithMany("reports")
                        .HasForeignKey("RealEstateID");

                    b.Navigation("realEstates");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KhoaLuanTotNghiep_BackEnd.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.Category", b =>
                {
                    b.Navigation("RealEstates");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.RealEstate", b =>
                {
                    b.Navigation("order");

                    b.Navigation("reports");
                });

            modelBuilder.Entity("KhoaLuanTotNghiep_BackEnd.Models.User", b =>
                {
                    b.Navigation("news");

                    b.Navigation("orderIdAdmin");

                    b.Navigation("orderIdUser");

                    b.Navigation("RealEstateIdAdmin");

                    b.Navigation("RealEstateIdUser");
                });
#pragma warning restore 612, 618
        }
    }
}

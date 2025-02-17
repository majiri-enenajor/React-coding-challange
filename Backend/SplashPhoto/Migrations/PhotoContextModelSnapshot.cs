﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SplashPhoto.Data;

namespace SplashPhoto.Migrations
{
    [DbContext(typeof(PhotoContext))]
    partial class PhotoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SplashPhoto.Models.CurrentUserCollection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserPhotoid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cover_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last_collected_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("published_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("user")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("UserPhotoid");

                    b.ToTable("CurrentUserCollections");
                });

            modelBuilder.Entity("SplashPhoto.Models.Links", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("download")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("download_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("html")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("self")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("SplashPhoto.Models.ProfileImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("large")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("small")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ProfileImages");
                });

            modelBuilder.Entity("SplashPhoto.Models.Urls", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("full")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("raw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("regular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("small")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("SplashPhoto.Models.User", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instagram_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("linksid")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolio_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("profile_imageid")
                        .HasColumnType("int");

                    b.Property<int>("total_collections")
                        .HasColumnType("int");

                    b.Property<int>("total_likes")
                        .HasColumnType("int");

                    b.Property<int>("total_photos")
                        .HasColumnType("int");

                    b.Property<string>("twitter_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("linksid");

                    b.HasIndex("profile_imageid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SplashPhoto.Models.UserPhoto", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("blur_hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<bool>("liked_by_user")
                        .HasColumnType("bit");

                    b.Property<int>("likes")
                        .HasColumnType("int");

                    b.Property<int?>("linksid")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("urlsid")
                        .HasColumnType("int");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("linksid");

                    b.HasIndex("urlsid");

                    b.HasIndex("userid");

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("SplashPhoto.Models.CurrentUserCollection", b =>
                {
                    b.HasOne("SplashPhoto.Models.UserPhoto", null)
                        .WithMany("current_user_collections")
                        .HasForeignKey("UserPhotoid");
                });

            modelBuilder.Entity("SplashPhoto.Models.User", b =>
                {
                    b.HasOne("SplashPhoto.Models.Links", "links")
                        .WithMany()
                        .HasForeignKey("linksid");

                    b.HasOne("SplashPhoto.Models.ProfileImage", "profile_image")
                        .WithMany()
                        .HasForeignKey("profile_imageid");
                });

            modelBuilder.Entity("SplashPhoto.Models.UserPhoto", b =>
                {
                    b.HasOne("SplashPhoto.Models.Links", "links")
                        .WithMany()
                        .HasForeignKey("linksid");

                    b.HasOne("SplashPhoto.Models.Urls", "urls")
                        .WithMany()
                        .HasForeignKey("urlsid");

                    b.HasOne("SplashPhoto.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid");
                });
#pragma warning restore 612, 618
        }
    }
}

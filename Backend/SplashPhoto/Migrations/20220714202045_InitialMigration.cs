using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplashPhoto.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    self = table.Column<string>(nullable: true),
                    html = table.Column<string>(nullable: true),
                    photos = table.Column<string>(nullable: true),
                    likes = table.Column<string>(nullable: true),
                    portfolio = table.Column<string>(nullable: true),
                    download = table.Column<string>(nullable: true),
                    download_location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small = table.Column<string>(nullable: true),
                    medium = table.Column<string>(nullable: true),
                    large = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileImages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raw = table.Column<string>(nullable: true),
                    full = table.Column<string>(nullable: true),
                    regular = table.Column<string>(nullable: true),
                    small = table.Column<string>(nullable: true),
                    thumb = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    portfolio_url = table.Column<string>(nullable: true),
                    bio = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    total_likes = table.Column<int>(nullable: false),
                    total_photos = table.Column<int>(nullable: false),
                    total_collections = table.Column<int>(nullable: false),
                    instagram_username = table.Column<string>(nullable: true),
                    twitter_username = table.Column<string>(nullable: true),
                    profile_imageid = table.Column<int>(nullable: true),
                    linksid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Links_linksid",
                        column: x => x.linksid,
                        principalTable: "Links",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_ProfileImages_profile_imageid",
                        column: x => x.profile_imageid,
                        principalTable: "ProfileImages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPhotos",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    width = table.Column<int>(nullable: false),
                    height = table.Column<int>(nullable: false),
                    color = table.Column<string>(nullable: true),
                    blur_hash = table.Column<string>(nullable: true),
                    likes = table.Column<int>(nullable: false),
                    liked_by_user = table.Column<bool>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    urlsid = table.Column<int>(nullable: true),
                    linksid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhotos", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserPhotos_Links_linksid",
                        column: x => x.linksid,
                        principalTable: "Links",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPhotos_Urls_urlsid",
                        column: x => x.urlsid,
                        principalTable: "Urls",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPhotos_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurrentUserCollections",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    published_at = table.Column<DateTime>(nullable: false),
                    last_collected_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    cover_photo = table.Column<string>(nullable: true),
                    user = table.Column<string>(nullable: true),
                    UserPhotoid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentUserCollections", x => x.id);
                    table.ForeignKey(
                        name: "FK_CurrentUserCollections_UserPhotos_UserPhotoid",
                        column: x => x.UserPhotoid,
                        principalTable: "UserPhotos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentUserCollections_UserPhotoid",
                table: "CurrentUserCollections",
                column: "UserPhotoid");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhotos_linksid",
                table: "UserPhotos",
                column: "linksid");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhotos_urlsid",
                table: "UserPhotos",
                column: "urlsid");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhotos_userid",
                table: "UserPhotos",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_linksid",
                table: "Users",
                column: "linksid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_profile_imageid",
                table: "Users",
                column: "profile_imageid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentUserCollections");

            migrationBuilder.DropTable(
                name: "UserPhotos");

            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "ProfileImages");
        }
    }
}

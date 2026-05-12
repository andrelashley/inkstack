using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inkstack.Api.Migrations
{
    /// <inheritdoc />
    public partial class ReorganizePostModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Post",
                newName: "Slug");

            migrationBuilder.AddColumn<string>(
                name: "ContentMarkdown",
                table: "Post",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAtUtc",
                table: "Post",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Excerpt",
                table: "Post",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Post",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Meta",
                table: "Post",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "PublishedAtUtc",
                table: "Post",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAtUtc",
                table: "Post",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentMarkdown",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CreatedAtUtc",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Excerpt",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Meta",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "PublishedAtUtc",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UpdatedAtUtc",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Post",
                newName: "ShortDescription");
        }
    }
}

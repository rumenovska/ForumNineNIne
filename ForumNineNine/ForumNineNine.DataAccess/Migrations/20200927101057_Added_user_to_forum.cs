using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumNineNine.DataAccess.Migrations
{
    public partial class Added_user_to_forum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "264220d5-ba5b-4f17-8ab4-8c5f621e2b76", "5b76a5a9-a4ce-45cf-a559-fb5357b3f808" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5b76a5a9-a4ce-45cf-a559-fb5357b3f808", "56997cba-bd57-47d5-a8cf-f5a71270795e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "264220d5-ba5b-4f17-8ab4-8c5f621e2b76", "d4d8344a-989c-40e5-b17b-cdcce9736a68" });

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Forums",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "747a10ca-c6ce-4603-919f-fd23cad1a5d7", "f452c6ea-9553-4c51-be90-7e08198c5c1c", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "MemberSince", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "022d6bf8-479d-4924-a709-255f8064f1f7", 0, "e09be911-b221-422e-8092-db1ada1d812e", "admin@mail.com", true, null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAbNakyPJJTVqW03eKw9QYiZaAb7DTEvejCWf8yutOjj0Jto3KCeWsgfhuf0thUBEQ==", null, false, null, 0, "", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "022d6bf8-479d-4924-a709-255f8064f1f7", "747a10ca-c6ce-4603-919f-fd23cad1a5d7" });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserId",
                table: "Forums",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_AspNetUsers_UserId",
                table: "Forums",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_AspNetUsers_UserId",
                table: "Forums");

            migrationBuilder.DropIndex(
                name: "IX_Forums_UserId",
                table: "Forums");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "022d6bf8-479d-4924-a709-255f8064f1f7", "747a10ca-c6ce-4603-919f-fd23cad1a5d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "747a10ca-c6ce-4603-919f-fd23cad1a5d7", "f452c6ea-9553-4c51-be90-7e08198c5c1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "022d6bf8-479d-4924-a709-255f8064f1f7", "e09be911-b221-422e-8092-db1ada1d812e" });

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Forums");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b76a5a9-a4ce-45cf-a559-fb5357b3f808", "56997cba-bd57-47d5-a8cf-f5a71270795e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "MemberSince", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "264220d5-ba5b-4f17-8ab4-8c5f621e2b76", 0, "d4d8344a-989c-40e5-b17b-cdcce9736a68", "admin@mail.com", true, null, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAfmGFRMkETad0LFKMTMkL3uklIHm2xdActjLVt20Bu8oYFmApmqxMHBrW0wUVL4OA==", null, false, null, 0, "", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "264220d5-ba5b-4f17-8ab4-8c5f621e2b76", "5b76a5a9-a4ce-45cf-a559-fb5357b3f808" });
        }
    }
}

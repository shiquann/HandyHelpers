using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HandyHelper.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CommentId",
                table: "Jobs",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Comments_CommentId",
                table: "Jobs",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Comments_CommentId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CommentId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Jobs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HandyHelper.Migrations
{
    public partial class refactoredcomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "Comments",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_JobId",
                table: "Comments",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Jobs_JobId",
                table: "Comments",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Jobs_JobId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_JobId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Comments",
                newName: "Comments");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Jobs",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HandyHelper.Migrations
{
    public partial class UserNameToJobPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Comments",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Comments",
                newName: "ContactName");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}

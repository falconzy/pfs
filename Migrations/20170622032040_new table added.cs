using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pfs.Migrations
{
    public partial class newtableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "AccountHistory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "AccountHistory",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "AccountHistory");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AccountHistory");
        }
    }
}

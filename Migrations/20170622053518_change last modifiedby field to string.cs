using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pfs.Migrations
{
    public partial class changelastmodifiedbyfieldtostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Stock",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Spending",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "MonthlySummary",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "ExchangeRate",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Currency",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "AccountHistory",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedBy",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedBy",
                table: "Stock",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedBy",
                table: "Spending",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedBy",
                table: "MonthlySummary",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedBy",
                table: "ExchangeRate",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedBy",
                table: "Currency",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedBy",
                table: "AccountHistory",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

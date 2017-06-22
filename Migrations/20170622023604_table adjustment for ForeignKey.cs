using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pfs.Migrations
{
    public partial class tableadjustmentforForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistory_Currency_CurrencyId",
                table: "AccountHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ExchangeRate_Currency_CurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropIndex(
                name: "IX_ExchangeRate_CurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropColumn(
                name: "CurrencyFK",
                table: "AccountHistory");

            migrationBuilder.RenameColumn(
                name: "foreignCurrencyFK",
                table: "ExchangeRate",
                newName: "LocalCurrencyId");

            migrationBuilder.RenameColumn(
                name: "LocalCurrencyFK",
                table: "ExchangeRate",
                newName: "ForeignCurrencyId");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "AccountHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRate_ForeignCurrencyId",
                table: "ExchangeRate",
                column: "ForeignCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRate_LocalCurrencyId",
                table: "ExchangeRate",
                column: "LocalCurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistory_Currency_CurrencyId",
                table: "AccountHistory",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExchangeRate_Currency_ForeignCurrencyId",
                table: "ExchangeRate",
                column: "ForeignCurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExchangeRate_Currency_LocalCurrencyId",
                table: "ExchangeRate",
                column: "LocalCurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistory_Currency_CurrencyId",
                table: "AccountHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ExchangeRate_Currency_ForeignCurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ExchangeRate_Currency_LocalCurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropIndex(
                name: "IX_ExchangeRate_ForeignCurrencyId",
                table: "ExchangeRate");

            migrationBuilder.DropIndex(
                name: "IX_ExchangeRate_LocalCurrencyId",
                table: "ExchangeRate");

            migrationBuilder.RenameColumn(
                name: "LocalCurrencyId",
                table: "ExchangeRate",
                newName: "foreignCurrencyFK");

            migrationBuilder.RenameColumn(
                name: "ForeignCurrencyId",
                table: "ExchangeRate",
                newName: "LocalCurrencyFK");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "ExchangeRate",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "AccountHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CurrencyFK",
                table: "AccountHistory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRate_CurrencyId",
                table: "ExchangeRate",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistory_Currency_CurrencyId",
                table: "AccountHistory",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExchangeRate_Currency_CurrencyId",
                table: "ExchangeRate",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pfs.Migrations
{
    public partial class changestockcodetounique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stock_StockCode",
                table: "Stock",
                column: "StockCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stock_StockCode",
                table: "Stock");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pfs.Migrations
{
    public partial class stocktranscationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockTranscations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    BuyAction = table.Column<bool>(nullable: false),
                    BuyPrice = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    Lots = table.Column<int>(nullable: false),
                    Profit = table.Column<decimal>(nullable: false),
                    SellPrice = table.Column<decimal>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 10, nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTranscations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTranscations");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using pfs.Persistence;

namespace pfs.Migrations
{
    [DbContext(typeof(PfsDbContext))]
    [Migration("20170621150631_add account table")]
    partial class addaccounttable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pfs.Core.model.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BuyPrice");

                    b.Property<decimal>("BuyValue");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<decimal>("CurrentPrice");

                    b.Property<decimal>("CurrentValue");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<int>("Lots");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("StockCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });
        }
    }
}

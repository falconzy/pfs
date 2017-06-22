using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using pfs.Persistence;

namespace pfs.Migrations
{
    [DbContext(typeof(PfsDbContext))]
    [Migration("20170622015851_table adjustment")]
    partial class tableadjustment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pfs.Core.model.AccountHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<decimal>("Amount");

                    b.Property<int>("CurrencyFK");

                    b.Property<int?>("CurrencyId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("ModifiedBy");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("AccountHistory");
                });

            modelBuilder.Entity("pfs.Core.model.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedBy");

                    b.Property<DateTime>("LastUpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("pfs.Core.model.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CurrencyId");

                    b.Property<DateTime>("LastModifiedBy");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("LocalCurrencyFK")
                        .HasMaxLength(10);

                    b.Property<decimal>("Rate");

                    b.Property<int>("foreignCurrencyFK")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("ExchangeRate");
                });

            modelBuilder.Entity("pfs.Core.model.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BuyPrice");

                    b.Property<decimal>("BuyValue");

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

            modelBuilder.Entity("pfs.Core.model.AccountHistory", b =>
                {
                    b.HasOne("pfs.Core.model.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");
                });

            modelBuilder.Entity("pfs.Core.model.ExchangeRate", b =>
                {
                    b.HasOne("pfs.Core.model.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");
                });
        }
    }
}

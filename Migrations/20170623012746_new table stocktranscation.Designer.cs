using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using pfs.Persistence;

namespace pfs.Migrations
{
    [DbContext(typeof(PfsDbContext))]
    [Migration("20170623012746_new table stocktranscation")]
    partial class newtablestocktranscation
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

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("Month");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<int>("Year");

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

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("pfs.Core.model.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ForeignCurrencyId")
                        .HasMaxLength(10);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("LocalCurrencyId")
                        .HasMaxLength(10);

                    b.Property<int>("Month");

                    b.Property<decimal>("Rate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ForeignCurrencyId");

                    b.HasIndex("LocalCurrencyId");

                    b.ToTable("ExchangeRate");
                });

            modelBuilder.Entity("pfs.Core.model.MonthlySummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CashFlow");

                    b.Property<decimal>("InvestmentAmount");

                    b.Property<decimal>("LivingCost");

                    b.Property<decimal>("LongTermFixAmount");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("Month");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("MonthlySummary");
                });

            modelBuilder.Entity("pfs.Core.model.Spending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("Month");

                    b.Property<int>("SpendingTypeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("SpendingTypeId");

                    b.ToTable("Spending");
                });

            modelBuilder.Entity("pfs.Core.model.SpendingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("SpendingType");
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

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<int>("Lots");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("StockCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("pfs.Core.model.Transactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedBy")
                        .IsRequired();

                    b.Property<int>("Month");

                    b.Property<int>("SpendingTypeId");

                    b.Property<int>("TransactionTypeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("SpendingTypeId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("pfs.Core.model.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("pfs.Core.model.AccountHistory", b =>
                {
                    b.HasOne("pfs.Core.model.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("pfs.Core.model.ExchangeRate", b =>
                {
                    b.HasOne("pfs.Core.model.Currency", "ForeignCurrency")
                        .WithMany()
                        .HasForeignKey("ForeignCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("pfs.Core.model.Currency", "LocalCurrency")
                        .WithMany()
                        .HasForeignKey("LocalCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("pfs.Core.model.Spending", b =>
                {
                    b.HasOne("pfs.Core.model.SpendingType", "SpendingType")
                        .WithMany()
                        .HasForeignKey("SpendingTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("pfs.Core.model.Transactions", b =>
                {
                    b.HasOne("pfs.Core.model.SpendingType", "SpendingType")
                        .WithMany()
                        .HasForeignKey("SpendingTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("pfs.Core.model.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

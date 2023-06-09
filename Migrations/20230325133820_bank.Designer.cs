﻿// <auto-generated />
using BankSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankSystem.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20230325133820_bank")]
    partial class bank
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankSystem.Data.CreditBooleanInfo", b =>
                {
                    b.Property<string>("Card_number")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Has_taken_credit")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Card_number");

                    b.ToTable("CreditBooleanInfos");
                });

            modelBuilder.Entity("BankSystem.Data.CreditDateInfo", b =>
                {
                    b.Property<string>("Card_number")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Credit_taken_date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Credit_toReturn_date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Card_number");

                    b.ToTable("CreditDateInfos");
                });

            modelBuilder.Entity("BankSystem.Data.CreditMoneyInfo", b =>
                {
                    b.Property<string>("Card_number")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("Credit_ToBePaid")
                        .HasColumnType("double");

                    b.Property<double>("Credit_amount")
                        .HasColumnType("double");

                    b.Property<double>("Credit_interest")
                        .HasColumnType("double");

                    b.HasKey("Card_number");

                    b.ToTable("CreditMoneyInfos");
                });

            modelBuilder.Entity("BankSystem.Data.UserBankInfo", b =>
                {
                    b.Property<string>("Card_number")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("Balance")
                        .HasColumnType("double");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Card_number");

                    b.ToTable("UserBankInfos");
                });

            modelBuilder.Entity("BankSystem.Data.UserIBANInfo", b =>
                {
                    b.Property<string>("IBAN")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IBAN");

                    b.ToTable("UserIBANInfos");
                });

            modelBuilder.Entity("BankSystem.Data.UserInfo", b =>
                {
                    b.Property<string>("EGN")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EGN");

                    b.ToTable("UserInfos");
                });
#pragma warning restore 612, 618
        }
    }
}

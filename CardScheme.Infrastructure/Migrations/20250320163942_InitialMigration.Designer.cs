﻿// <auto-generated />
using System;
using CardScheme.Infrastructure.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardScheme.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250320163942_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardScheme.Domain.Entity.CardTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CardTypes");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("customersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("customersId");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.CustomerCards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardPan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardTypesId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ExpireDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("customersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardTypesId");

                    b.HasIndex("customersId");

                    b.ToTable("CustomerCards");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSmsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phoneno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.CustomerAddress", b =>
                {
                    b.HasOne("CardScheme.Domain.Entity.Customers", "customers")
                        .WithMany("customerAddresses")
                        .HasForeignKey("customersId");

                    b.Navigation("customers");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.CustomerCards", b =>
                {
                    b.HasOne("CardScheme.Domain.Entity.CardTypes", "card")
                        .WithMany()
                        .HasForeignKey("CardTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardScheme.Domain.Entity.Customers", "customers")
                        .WithMany("customerCards")
                        .HasForeignKey("customersId");

                    b.Navigation("card");

                    b.Navigation("customers");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.Customers", b =>
                {
                    b.HasOne("CardScheme.Domain.Entity.Gender", "gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gender");
                });

            modelBuilder.Entity("CardScheme.Domain.Entity.Customers", b =>
                {
                    b.Navigation("customerAddresses");

                    b.Navigation("customerCards");
                });
#pragma warning restore 612, 618
        }
    }
}

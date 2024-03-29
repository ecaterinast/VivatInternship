﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VivatInternship.Backend.Data.DbModel;

#nullable disable

namespace VivatInternship.Backend.Migrations
{
    [DbContext(typeof(BasketContext))]
    [Migration("20230622092936_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VivatInternship.Backend.Data.Baskets", b =>
                {
                    b.Property<long>("UniqueBasketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UniqueBasketId"));

                    b.Property<DateTimeOffset>("CreatedTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentInitiated")
                        .HasColumnType("bit");

                    b.Property<string>("StoreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniqueBasketId");

                    b.ToTable("Baskets");
                });
#pragma warning restore 612, 618
        }
    }
}

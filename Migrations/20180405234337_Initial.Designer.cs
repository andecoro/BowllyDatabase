﻿// <auto-generated />
using BowllyForever.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BowllyForever.Migrations
{
    [DbContext(typeof(EF_BowllyContext))]
    [Migration("20180405234337_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BowllyForever.Models.Cassette", b =>
                {
                    b.Property<int>("CassetteId")
                        .HasColumnName("CassetteID");

                    b.Property<string>("Artist")
                        .HasMaxLength(50);

                    b.Property<string>("CatNo")
                        .HasColumnName("Cat_No")
                        .HasMaxLength(255);

                    b.Property<string>("Label")
                        .HasMaxLength(255);

                    b.Property<string>("Location")
                        .HasMaxLength(255);

                    b.Property<string>("RecordCo")
                        .HasColumnName("Record_Co")
                        .HasMaxLength(50);

                    b.Property<int?>("Released");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("CassetteId");

                    b.ToTable("cassette");
                });

            modelBuilder.Entity("BowllyForever.Models.Cd", b =>
                {
                    b.Property<int>("Cdid")
                        .HasColumnName("CDID");

                    b.Property<string>("Artist")
                        .HasMaxLength(50);

                    b.Property<string>("CatNo")
                        .HasColumnName("Cat_No")
                        .HasMaxLength(50);

                    b.Property<string>("Label")
                        .HasMaxLength(255);

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<string>("RecordCo")
                        .HasColumnName("Record_Co")
                        .HasMaxLength(50);

                    b.Property<int?>("Released");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("Cdid");

                    b.ToTable("cd");
                });

            modelBuilder.Entity("BowllyForever.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnName("TrackID");

                    b.Property<string>("Artist")
                        .HasMaxLength(255);

                    b.Property<string>("CatNo")
                        .HasColumnName("Cat_No")
                        .HasMaxLength(255);

                    b.Property<string>("Comments");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Image");

                    b.Property<string>("Label")
                        .HasMaxLength(255);

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<string>("Matrix")
                        .HasMaxLength(50);

                    b.Property<string>("Music")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<string>("Words")
                        .HasMaxLength(50);

                    b.Property<string>("Youtube");

                    b.HasKey("TrackId");

                    b.ToTable("track");
                });

            modelBuilder.Entity("BowllyForever.Models.Vinyl", b =>
                {
                    b.Property<int>("VinylId")
                        .HasColumnName("VinylID");

                    b.Property<string>("Artist")
                        .HasMaxLength(50);

                    b.Property<string>("CatNo")
                        .HasColumnName("Cat_No")
                        .HasMaxLength(50);

                    b.Property<string>("Label")
                        .HasMaxLength(50);

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<string>("RecordCo")
                        .HasColumnName("Record_Co")
                        .HasMaxLength(50);

                    b.Property<string>("Size")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.Property<string>("Year")
                        .HasColumnType("nchar(10)");

                    b.HasKey("VinylId");

                    b.ToTable("vinyl");
                });
#pragma warning restore 612, 618
        }
    }
}

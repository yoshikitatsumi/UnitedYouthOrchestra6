﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitedYouthOrchestra6.Data;

namespace UnitedYouthOrchestra6.Migrations
{
    [DbContext(typeof(UnitedYouthOrchestra6Context))]
    partial class UnitedYouthOrchestra6ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnitedYouthOrchestra6.Models.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bassoon")
                        .HasColumnType("bit");

                    b.Property<bool>("Cello")
                        .HasColumnType("bit");

                    b.Property<bool>("Clarinet")
                        .HasColumnType("bit");

                    b.Property<bool>("DoubleBass")
                        .HasColumnType("bit");

                    b.Property<bool>("Flute")
                        .HasColumnType("bit");

                    b.Property<bool>("Horn")
                        .HasColumnType("bit");

                    b.Property<bool>("Keyboard")
                        .HasColumnType("bit");

                    b.Property<bool>("Oboe")
                        .HasColumnType("bit");

                    b.Property<bool>("TimpaniPerc")
                        .HasColumnType("bit");

                    b.Property<bool>("Trombone")
                        .HasColumnType("bit");

                    b.Property<bool>("Trumpet")
                        .HasColumnType("bit");

                    b.Property<bool>("Tuba")
                        .HasColumnType("bit");

                    b.Property<bool>("Viola")
                        .HasColumnType("bit");

                    b.Property<bool>("Violin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("UnitedYouthOrchestra6.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstFK")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SYearFK")
                        .HasColumnType("int");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstFK");

                    b.HasIndex("SYearFK");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("UnitedYouthOrchestra6.Models.SchoolYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Other")
                        .HasColumnType("bit");

                    b.Property<bool>("Year10")
                        .HasColumnType("bit");

                    b.Property<bool>("Year11")
                        .HasColumnType("bit");

                    b.Property<bool>("Year12")
                        .HasColumnType("bit");

                    b.Property<bool>("Year13")
                        .HasColumnType("bit");

                    b.Property<bool>("Year6orEarlier")
                        .HasColumnType("bit");

                    b.Property<bool>("Year7")
                        .HasColumnType("bit");

                    b.Property<bool>("Year8")
                        .HasColumnType("bit");

                    b.Property<bool>("Year9")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SchoolYear");
                });

            modelBuilder.Entity("UnitedYouthOrchestra6.Models.Member", b =>
                {
                    b.HasOne("UnitedYouthOrchestra6.Models.Instrument", "instrument")
                        .WithMany()
                        .HasForeignKey("InstFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnitedYouthOrchestra6.Models.SchoolYear", "schoolyear")
                        .WithMany()
                        .HasForeignKey("SYearFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

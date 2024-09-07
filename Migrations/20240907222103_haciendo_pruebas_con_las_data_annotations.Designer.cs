﻿// <auto-generated />
using ApiExample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiExample.Migrations
{
    [DbContext(typeof(ConnectionDbContext))]
    [Migration("20240907222103_haciendo_pruebas_con_las_data_annotations")]
    partial class haciendo_pruebas_con_las_data_annotations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ApiExample.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(125)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("NumberPhone")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("owners");
                });

            modelBuilder.Entity("ApiExample.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfVehicle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("vehicles", (string)null);
                });

            modelBuilder.Entity("ApiExample.Models.Vehicle", b =>
                {
                    b.HasOne("ApiExample.Models.Owner", "Owner")
                        .WithMany("Vehicles")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ApiExample.Models.Owner", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}

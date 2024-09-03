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
    [Migration("20240903121203_se_agrego_la_propiedad_profile_picture_y_se_agregaron_data_annotations")]
    partial class se_agrego_la_propiedad_profile_picture_y_se_agregaron_data_annotations
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

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ApiExample.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfVehicle")
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("ApiExample.Models.Vehicle", b =>
                {
                    b.HasOne("ApiExample.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}

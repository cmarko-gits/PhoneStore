﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20241219204346_CreatedAdded")]
    partial class CreatedAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long?>("OldPrice")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.OwnsOne("API.Entitiees.Specification.Specification", "Specifications", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("BatteryCapacity")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Brand")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("CPU")
                                .HasColumnType("TEXT");

                            b1.Property<bool>("FastCharging")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("FastChargingWatt")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("InternalStorage")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("OperatingSystem")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("RAM")
                                .HasColumnType("INTEGER");

                            b1.Property<float>("ScreenSize")
                                .HasColumnType("REAL");

                            b1.Property<string>("ScreenType")
                                .HasColumnType("TEXT");

                            b1.Property<bool>("WirelessCharging")
                                .HasColumnType("INTEGER");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.OwnsMany("API.Entitiees.Specification.CameraSpecifications", "Cameras", b2 =>
                                {
                                    b2.Property<int>("SpecificationProductId")
                                        .HasColumnType("INTEGER");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("INTEGER");

                                    b2.Property<int>("CameraType")
                                        .HasColumnType("INTEGER");

                                    b2.Property<bool>("IsStabilized")
                                        .HasColumnType("INTEGER");

                                    b2.Property<int>("Megapixels")
                                        .HasColumnType("INTEGER");

                                    b2.HasKey("SpecificationProductId", "Id");

                                    b2.ToTable("CameraSpecifications");

                                    b2.WithOwner()
                                        .HasForeignKey("SpecificationProductId");
                                });

                            b1.Navigation("Cameras");
                        });

                    b.Navigation("Specifications");
                });
#pragma warning restore 612, 618
        }
    }
}

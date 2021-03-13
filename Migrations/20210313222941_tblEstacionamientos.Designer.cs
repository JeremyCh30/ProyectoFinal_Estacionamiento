﻿// <auto-generated />
using System;
using ElParqueito;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElParqueito.Migrations
{
    [DbContext(typeof(CadenaDeParqueosContext))]
    [Migration("20210313222941_tblEstacionamientos")]
    partial class tblEstacionamientos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ElParqueito.Models.Estacionamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cobro")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HoraDeEntrada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HoraDeSalida")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numeroPosicion")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("vehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("vehiculoId");

                    b.ToTable("Estacionamientos");
                });

            modelBuilder.Entity("ElParqueito.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("ElParqueito.Models.Estacionamiento", b =>
                {
                    b.HasOne("ElParqueito.Models.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoId");

                    b.Navigation("vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}

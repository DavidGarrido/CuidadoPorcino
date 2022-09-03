﻿// <auto-generated />
using CuidadoPorcino.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    [DbContext(typeof(appContext))]
    [Migration("20220903115332_last")]
    partial class last
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Cerdos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cerdos");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Historia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("id_cerdo")
                        .HasColumnType("int");

                    b.Property<int>("id_propietario")
                        .HasColumnType("int");

                    b.Property<int>("id_veterinario")
                        .HasColumnType("int");

                    b.Property<int>("utc_apertura")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Historia");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("estadoAnimo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("frecuenciaCardiaca")
                        .HasColumnType("int");

                    b.Property<int>("frecuenciaRespiratoria")
                        .HasColumnType("int");

                    b.Property<int>("id_historia")
                        .HasColumnType("int");

                    b.Property<double>("peso")
                        .HasColumnType("float");

                    b.Property<string>("recomendaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("temperatura")
                        .HasColumnType("float");

                    b.Property<int>("utc_visita")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("CuidadoPorcino.App.Dominio.Persona");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("CuidadoPorcino.App.Dominio.Persona");

                    b.Property<int>("tarjetaProfesional")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}

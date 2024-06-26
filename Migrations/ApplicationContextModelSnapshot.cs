﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalAgencyApi.Models;

#nullable disable

namespace RentalAgencyApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentalAgencyApi.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("RentalAgencyApi.Models.Marca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("RentalAgencyApi.Models.Reserva", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Id"));

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<long>("IdVeiculo")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("RentalAgencyApi.Models.Veiculo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<long>("IdMarca")
                        .HasColumnType("bigint");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PrecoDia")
                        .HasColumnType("float");

                    b.Property<double?>("Quilometragem")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}

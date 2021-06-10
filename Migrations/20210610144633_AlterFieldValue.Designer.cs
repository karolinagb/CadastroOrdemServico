﻿// <auto-generated />
using System;
using CadastroOrdemServico.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroOrdemServico.Migrations
{
    [DbContext(typeof(CadastroOrdemServicoContext))]
    [Migration("20210610144633_AlterFieldValue")]
    partial class AlterFieldValue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("CadastroOrdemServico.Models.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("CPFPrestadorServico")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("NomePrestadorServico")
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OrdensServico");
                });
#pragma warning restore 612, 618
        }
    }
}

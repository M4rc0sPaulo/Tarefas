﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TarefasAPI.Data;

#nullable disable

namespace TarefasAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230621011752_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tarefas.Models.Anotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPrioridade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anotacoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2023, 6, 25, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Refazer atividade pendente do dia 19/05. Continuar a sua escrita normalmente",
                            IdPrioridade = 2,
                            Nome = "Refazer Atividade",
                            Tipo = "Trabalho"
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2023, 6, 30, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Mestrar uma mesa de RPG chamada Reflexo do Outro Lado. Preparar tudo que precisa ser feito como músicas, tokens e mapas  ",
                            IdPrioridade = 1,
                            Nome = "Mestrar RPG Ordem",
                            Tipo = "Atividade"
                        },
                        new
                        {
                            Id = 3,
                            Data = new DateTime(2023, 7, 10, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Continuar Atividade de Banco de Dados do dia 13/06",
                            IdPrioridade = 1,
                            Nome = "Continuar Banco",
                            Tipo = "Escola"
                        },
                        new
                        {
                            Id = 4,
                            Data = new DateTime(2023, 6, 27, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Dentista marcado as 17:30",
                            IdPrioridade = 2,
                            Nome = "Dentista",
                            Tipo = "Saúde"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

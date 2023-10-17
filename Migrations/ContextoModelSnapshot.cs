﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakersProjetoFinal.Models;

#nullable disable

namespace SneakersProjetoFinal.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SneakersProjetoFinal.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Cadastro");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CPFCadastro")
                        .HasColumnType("int")
                        .HasColumnName("CPF");

                    b.Property<string>("EmailCadastro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("NomeCadastro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("SneakersProjetoFinal.Models.CadastroProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_CadastroProduto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescricaoProduto");

                    b.Property<int>("Id_Categoria")
                        .HasColumnType("int");

                    b.Property<string>("ImagemProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImagemProduto");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeProduto");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("CadastroProduto");
                });

            modelBuilder.Entity("SneakersProjetoFinal.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Categoria");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeCategoria");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SneakersProjetoFinal.Models.CadastroProduto", b =>
                {
                    b.HasOne("SneakersProjetoFinal.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}

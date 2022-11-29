﻿// <auto-generated />
using System;
using Api.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221128235541_estoque3")]
    partial class estoque3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Api.Backend.Domain.Models.Campanha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Dt_fim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Dt_inicio")
                        .HasColumnType("datetime");

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("int");

                    b.Property<string>("Logotipo")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CampanhaId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("text");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Qtde")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Instituicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18, 8)");

                    b.Property<string>("Logotipo")
                        .HasColumnType("text");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18, 8)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Instituicaos");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Maladireta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Maladiretas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Qtde")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Produto_Campanha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CampanhaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Produto_Campanhas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Funcao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Campanha", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Instituicao", "Instituicao")
                        .WithMany("Campanhas")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Estoque", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Campanha", "Campanha")
                        .WithMany("Estoques")
                        .HasForeignKey("CampanhaId");

                    b.HasOne("Api.Backend.Domain.Models.Produto", "Produto")
                        .WithMany("Estoques")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Instituicao", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Usuario", "Usuario")
                        .WithMany("Instituicaos")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Maladireta", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Instituicao", "Instituicao")
                        .WithMany("Maladiretas")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Produto", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Produto_Campanha", b =>
                {
                    b.HasOne("Api.Backend.Domain.Models.Campanha", "Campanha")
                        .WithMany("Produto_Campanhas")
                        .HasForeignKey("CampanhaId");

                    b.HasOne("Api.Backend.Domain.Models.Produto", "Produto")
                        .WithMany("Produto_Campanhas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Campanha", b =>
                {
                    b.Navigation("Estoques");

                    b.Navigation("Produto_Campanhas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Instituicao", b =>
                {
                    b.Navigation("Campanhas");

                    b.Navigation("Maladiretas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Produto", b =>
                {
                    b.Navigation("Estoques");

                    b.Navigation("Produto_Campanhas");
                });

            modelBuilder.Entity("Api.Backend.Domain.Models.Usuario", b =>
                {
                    b.Navigation("Instituicaos");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Backend_PIB_Cubatao.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_PIB_Cubatao.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240808152802_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Doacao", b =>
                {
                    b.Property<int>("DoacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DoacaoID"));

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IgrejaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("DoacaoID");

                    b.ToTable("Doacao");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Eventos", b =>
                {
                    b.Property<int>("EventoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EventoID"));

                    b.Property<DateTime>("DataHoraFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IgrejaID")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("MembroID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("EventoID");

                    b.HasIndex("IgrejaID");

                    b.HasIndex("MembroID");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Igreja", b =>
                {
                    b.Property<int>("IgrejaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IgrejaID"));

                    b.Property<DateTime>("DataDeFundacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IgrejaID");

                    b.ToTable("Igreja");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Membro", b =>
                {
                    b.Property<int>("MembroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MembroID"));

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("MinisterioID")
                        .HasColumnType("int");

                    b.Property<string>("NomeMembro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SobrenomeMembro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("MembroID");

                    b.HasIndex("MinisterioID");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Ministerio", b =>
                {
                    b.Property<int>("MinisterioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MinisterioID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("IgrejaID")
                        .HasColumnType("int");

                    b.Property<int>("MembroID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("MinisterioID");

                    b.HasIndex("IgrejaID");

                    b.HasIndex("MembroID");

                    b.ToTable("Ministerio");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Noticia", b =>
                {
                    b.Property<int>("NoticiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("NoticiaID"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("DataPublicao")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IgrejaID")
                        .HasColumnType("int");

                    b.Property<int>("MembroID")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("NoticiaID");

                    b.HasIndex("IgrejaID");

                    b.HasIndex("MembroID");

                    b.ToTable("Noticia");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Pagina", b =>
                {
                    b.Property<int>("PaginaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PaginaID"));

                    b.Property<string>("LinkVideo")
                        .IsRequired()
                        .HasMaxLength(259)
                        .HasColumnType("varchar(259)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("PaginaID");

                    b.ToTable("Pagina");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Sermao", b =>
                {
                    b.Property<int>("SermaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SermaoID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LinkVideo")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("MembroID")
                        .HasColumnType("int");

                    b.Property<string>("TextoBiblico")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("SermaoID");

                    b.HasIndex("MembroID");

                    b.ToTable("Sermao");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Eventos", b =>
                {
                    b.HasOne("Backend_PIB_Cubatao.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_PIB_Cubatao.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Membro", b =>
                {
                    b.HasOne("Backend_PIB_Cubatao.Models.Ministerio", "Ministerio")
                        .WithMany()
                        .HasForeignKey("MinisterioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ministerio");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Ministerio", b =>
                {
                    b.HasOne("Backend_PIB_Cubatao.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_PIB_Cubatao.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Noticia", b =>
                {
                    b.HasOne("Backend_PIB_Cubatao.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_PIB_Cubatao.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Backend_PIB_Cubatao.Models.Sermao", b =>
                {
                    b.HasOne("Backend_PIB_Cubatao.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membro");
                });
#pragma warning restore 612, 618
        }
    }
}

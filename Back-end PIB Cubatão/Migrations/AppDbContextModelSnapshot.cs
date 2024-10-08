﻿// <auto-generated />
using System;
using Back_end_PIB_Cubatão.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back_end_PIB_Cubatão.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Doacao", b =>
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

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Eventos", b =>
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

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Igreja", b =>
                {
                    b.Property<int>("IgrejaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IgrejaID"));

                    b.Property<DateTime>("DataDeFundacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

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

                    b.HasData(
                        new
                        {
                            IgrejaID = 1,
                            DataDeFundacao = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "secretaria@pibcubatao.org.br",
                            Endereco = "Rua Pedro de Toledo, 137, Vila Santa Rosa Cubatão",
                            Nome = "Igreja PIB Cubatao"
                        });
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Membro", b =>
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

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("MembroID");

                    b.HasIndex("MinisterioID");

                    b.ToTable("Membro");

                    b.HasData(
                        new
                        {
                            MembroID = 1,
                            DataDeCadastro = new DateTime(2024, 8, 2, 15, 51, 1, 287, DateTimeKind.Local).AddTicks(5727),
                            DataDeNascimento = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "joao.silva@example.com",
                            MinisterioID = 1,
                            NomeMembro = "João",
                            SobrenomeMembro = "Silva",
                            Status = 0,
                            Telefone = "123456789"
                        });
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Ministerio", b =>
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

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Noticia", b =>
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

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Pagina", b =>
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

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Sermao", b =>
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

                    b.HasData(
                        new
                        {
                            SermaoID = 1,
                            Data = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Sermão sobre a fé",
                            LinkVideo = "https://example.com/sermao1",
                            MembroID = 1,
                            TextoBiblico = "Mateus 17:20",
                            Titulo = "A Fé que Move Montanhas"
                        });
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Eventos", b =>
                {
                    b.HasOne("Back_end_PIB_Cubatão.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back_end_PIB_Cubatão.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Membro", b =>
                {
                    b.HasOne("Back_end_PIB_Cubatão.Models.Ministerio", "Ministerio")
                        .WithMany()
                        .HasForeignKey("MinisterioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ministerio");
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Ministerio", b =>
                {
                    b.HasOne("Back_end_PIB_Cubatão.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back_end_PIB_Cubatão.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Noticia", b =>
                {
                    b.HasOne("Back_end_PIB_Cubatão.Models.Igreja", "Igreja")
                        .WithMany()
                        .HasForeignKey("IgrejaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back_end_PIB_Cubatão.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igreja");

                    b.Navigation("Membro");
                });

            modelBuilder.Entity("Back_end_PIB_Cubatão.Models.Sermao", b =>
                {
                    b.HasOne("Back_end_PIB_Cubatão.Models.Membro", "Membro")
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

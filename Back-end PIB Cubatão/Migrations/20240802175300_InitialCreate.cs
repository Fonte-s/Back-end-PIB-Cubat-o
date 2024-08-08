using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_end_PIB_Cubatão.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doacao",
                columns: table => new
                {
                    DoacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IgrejaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacao", x => x.DoacaoID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Igreja",
                columns: table => new
                {
                    IgrejaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    DataDeFundacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igreja", x => x.IgrejaID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pagina",
                columns: table => new
                {
                    PaginaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LinkVideo = table.Column<string>(type: "varchar(259)", maxLength: 259, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagina", x => x.PaginaID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataHoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Local = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IgrejaID = table.Column<int>(type: "int", nullable: false),
                    MembroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoID);
                    table.ForeignKey(
                        name: "FK_Eventos_Igreja_IgrejaID",
                        column: x => x.IgrejaID,
                        principalTable: "Igreja",
                        principalColumn: "IgrejaID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Membro",
                columns: table => new
                {
                    MembroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeMembro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SobrenomeMembro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MinisterioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membro", x => x.MembroID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ministerio",
                columns: table => new
                {
                    MinisterioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IgrejaID = table.Column<int>(type: "int", nullable: false),
                    MembroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministerio", x => x.MinisterioID);
                    table.ForeignKey(
                        name: "FK_Ministerio_Igreja_IgrejaID",
                        column: x => x.IgrejaID,
                        principalTable: "Igreja",
                        principalColumn: "IgrejaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ministerio_Membro_MembroID",
                        column: x => x.MembroID,
                        principalTable: "Membro",
                        principalColumn: "MembroID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    NoticiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Conteudo = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataPublicao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IgrejaID = table.Column<int>(type: "int", nullable: false),
                    MembroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.NoticiaID);
                    table.ForeignKey(
                        name: "FK_Noticia_Igreja_IgrejaID",
                        column: x => x.IgrejaID,
                        principalTable: "Igreja",
                        principalColumn: "IgrejaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Noticia_Membro_MembroID",
                        column: x => x.MembroID,
                        principalTable: "Membro",
                        principalColumn: "MembroID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sermao",
                columns: table => new
                {
                    SermaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MembroID = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TextoBiblico = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LinkVideo = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sermao", x => x.SermaoID);
                    table.ForeignKey(
                        name: "FK_Sermao_Membro_MembroID",
                        column: x => x.MembroID,
                        principalTable: "Membro",
                        principalColumn: "MembroID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_IgrejaID",
                table: "Eventos",
                column: "IgrejaID");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_MembroID",
                table: "Eventos",
                column: "MembroID");

            migrationBuilder.CreateIndex(
                name: "IX_Membro_MinisterioID",
                table: "Membro",
                column: "MinisterioID");

            migrationBuilder.CreateIndex(
                name: "IX_Ministerio_IgrejaID",
                table: "Ministerio",
                column: "IgrejaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ministerio_MembroID",
                table: "Ministerio",
                column: "MembroID");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_IgrejaID",
                table: "Noticia",
                column: "IgrejaID");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_MembroID",
                table: "Noticia",
                column: "MembroID");

            migrationBuilder.CreateIndex(
                name: "IX_Sermao_MembroID",
                table: "Sermao",
                column: "MembroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Membro_MembroID",
                table: "Eventos",
                column: "MembroID",
                principalTable: "Membro",
                principalColumn: "MembroID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Ministerio_MinisterioID",
                table: "Membro",
                column: "MinisterioID",
                principalTable: "Ministerio",
                principalColumn: "MinisterioID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ministerio_Igreja_IgrejaID",
                table: "Ministerio");

            migrationBuilder.DropForeignKey(
                name: "FK_Ministerio_Membro_MembroID",
                table: "Ministerio");

            migrationBuilder.DropTable(
                name: "Doacao");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Pagina");

            migrationBuilder.DropTable(
                name: "Sermao");

            migrationBuilder.DropTable(
                name: "Igreja");

            migrationBuilder.DropTable(
                name: "Membro");

            migrationBuilder.DropTable(
                name: "Ministerio");
        }
    }
}

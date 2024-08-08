using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_end_PIB_Cubatão.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Membro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Igreja",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Igreja",
                columns: new[] { "IgrejaID", "DataDeFundacao", "Email", "Endereco", "Nome" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "secretaria@pibcubatao.org.br", "Rua Pedro de Toledo, 137, Vila Santa Rosa Cubatão", "Igreja PIB Cubatao" });

            migrationBuilder.InsertData(
                table: "Membro",
                columns: new[] { "MembroID", "DataDeCadastro", "DataDeNascimento", "Email", "MinisterioID", "NomeMembro", "SobrenomeMembro", "Status", "Telefone" },
                values: new object[] { 1, new DateTime(2024, 8, 2, 15, 51, 1, 287, DateTimeKind.Local).AddTicks(5727), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao.silva@example.com", 1, "João", "Silva", 0, "123456789" });

            migrationBuilder.InsertData(
                table: "Sermao",
                columns: new[] { "SermaoID", "Data", "Descricao", "LinkVideo", "MembroID", "TextoBiblico", "Titulo" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sermão sobre a fé", "https://example.com/sermao1", 1, "Mateus 17:20", "A Fé que Move Montanhas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Igreja",
                keyColumn: "IgrejaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sermao",
                keyColumn: "SermaoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Membro",
                keyColumn: "MembroID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Membro");

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Igreja",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

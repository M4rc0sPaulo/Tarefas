using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarefasAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anotacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPrioridade = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacoes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Anotacoes",
                columns: new[] { "Id", "Data", "Descricao", "IdPrioridade", "Nome", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 1, 0, 0, 0, DateTimeKind.Unspecified), "Refazer atividade pendente do dia 19/05. Continuar a sua escrita normalmente", 2, "Refazer Atividade", "Trabalho" },
                    { 2, new DateTime(2023, 6, 30, 1, 0, 0, 0, DateTimeKind.Unspecified), "Mestrar uma mesa de RPG chamada Reflexo do Outro Lado. Preparar tudo que precisa ser feito como músicas, tokens e mapas  ", 1, "Mestrar RPG Ordem", "Atividade" },
                    { 3, new DateTime(2023, 7, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), "Continuar Atividade de Banco de Dados do dia 13/06", 1, "Continuar Banco", "Escola" },
                    { 4, new DateTime(2023, 6, 27, 1, 0, 0, 0, DateTimeKind.Unspecified), "Dentista marcado as 17:30", 2, "Dentista", "Saúde" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotacoes");
        }
    }
}

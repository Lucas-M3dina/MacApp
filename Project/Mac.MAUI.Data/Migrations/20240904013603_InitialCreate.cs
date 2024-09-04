using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mac.MAUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id_Contrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nm_Empreendimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nm_Bloco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nm_Unidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nm_Contrato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fl_Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id_Contrato);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrato");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ElParqueito.Migrations
{
    public partial class AgregandoFacturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    estacionamientoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facturas_Estacionamientos_estacionamientoId",
                        column: x => x.estacionamientoId,
                        principalTable: "Estacionamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_estacionamientoId",
                table: "facturas",
                column: "estacionamientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "facturas");
        }
    }
}

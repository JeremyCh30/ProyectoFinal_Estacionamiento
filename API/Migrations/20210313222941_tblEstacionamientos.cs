using Microsoft.EntityFrameworkCore.Migrations;

namespace ElParqueito.Migrations
{
    public partial class tblEstacionamientos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estacionamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoraDeEntrada = table.Column<int>(type: "INTEGER", nullable: false),
                    numeroPosicion = table.Column<int>(type: "INTEGER", nullable: false),
                    vehiculoId = table.Column<int>(type: "INTEGER", nullable: true),
                    HoraDeSalida = table.Column<int>(type: "INTEGER", nullable: false),
                    Cobro = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estacionamientos_Vehiculos_vehiculoId",
                        column: x => x.vehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamientos_vehiculoId",
                table: "Estacionamientos",
                column: "vehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estacionamientos");
        }
    }
}

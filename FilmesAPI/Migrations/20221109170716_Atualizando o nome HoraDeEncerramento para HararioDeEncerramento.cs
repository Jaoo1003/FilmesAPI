using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    public partial class AtualizandoonomeHoraDeEncerramentoparaHararioDeEncerramento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoraDeEncerramento",
                table: "Sessoes",
                newName: "HorarioDeEncerramento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HorarioDeEncerramento",
                table: "Sessoes",
                newName: "HoraDeEncerramento");
        }
    }
}

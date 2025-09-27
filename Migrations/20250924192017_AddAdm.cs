using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dio_minimal_api.Migrations
{
    /// <inheritdoc />
    public partial class AddAdm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "adm@teste.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "administra@teste.com");
        }
    }
}

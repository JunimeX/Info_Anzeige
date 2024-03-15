using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Info_Anzeige.Migrations
{
    /// <inheritdoc />
    public partial class firstdataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Benutzer",
                columns: new[] { "Benutzer_ID", "Berechtigung", "Name", "Passwort" },
                values: new object[] { 1L, "Admin", "Admin", "0000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Benutzer",
                keyColumn: "Benutzer_ID",
                keyValue: 1L);
        }
    }
}

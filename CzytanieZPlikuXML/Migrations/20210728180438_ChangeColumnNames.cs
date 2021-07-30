using Microsoft.EntityFrameworkCore.Migrations;

namespace CzytanieZPlikuXML.Migrations
{
    public partial class ChangeColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contact",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "surName",
                table: "Contact",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contact",
                newName: "Imie");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Contact",
                newName: "Telefon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contact",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "Contact",
                newName: "surName");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "Contact",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Contact",
                newName: "phoneNumber");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactApp.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "techno",
                table: "Contacts",
                newName: "Techno");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "message",
                table: "Contacts",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Contacts",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "birth",
                table: "Contacts",
                newName: "Birth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contacts",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Techno",
                table: "Contacts",
                newName: "techno");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Contacts",
                newName: "message");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Contacts",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Birth",
                table: "Contacts",
                newName: "birth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "id");
        }
    }
}

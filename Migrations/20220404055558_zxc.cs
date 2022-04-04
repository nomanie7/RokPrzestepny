using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RokPrzestepny.Migrations
{
    public partial class zxc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Person",
                newName: "PersonId");
        }
    }
}

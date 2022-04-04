using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RokPrzestepny.Migrations
{
    public partial class qq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Person",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Person",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}

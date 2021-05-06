using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzz_WebApp.Migrations
{
    public partial class UserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uzytkownik",
                table: "FizzBuzzTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uzytkownik",
                table: "FizzBuzzTable");
        }
    }
}

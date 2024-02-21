using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerBlazorEF.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "ConfirmPassword",
                value: "password1");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "ConfirmPassword",
                value: "password2");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "ConfirmPassword",
                value: "password3");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "ConfirmPassword",
                value: "password4");
        }
    }
}

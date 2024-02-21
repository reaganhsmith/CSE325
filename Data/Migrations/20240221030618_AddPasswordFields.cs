using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerBlazorEF.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 57);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "ConfirmPassword", "Password" },
                values: new object[] { "password1", "password1" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "ConfirmPassword", "Password" },
                values: new object[] { "password2", "password2" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "ConfirmPassword", "Password" },
                values: new object[] { "password3", "password3" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "ConfirmPassword", "Password" },
                values: new object[] { "password4", "password4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Students");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { 5, "Ben", "Ray", "Mining" },
                    { 6, "Zoe", "Cox", "Business" },
                    { 7, "Sam", "Ray", "Mining" },
                    { 8, "Dan", "Ash", "Medicine" },
                    { 9, "Pat", "Lee", "Computing" },
                    { 10, "Kim", "Day", "Nursing" },
                    { 11, "Tim", "Rex", "Computing" },
                    { 12, "Rob", "Ram", "Business" },
                    { 13, "Jan", "Fry", "Mining" },
                    { 14, "Jim", "Tex", "Nursing" },
                    { 15, "Ben", "Kid", "Business" },
                    { 16, "Mia", "Chu", "Medicine" },
                    { 17, "Ted", "Tao", "Computing" },
                    { 18, "Amy", "Day", "Business" },
                    { 19, "Ian", "Roy", "Nursing" },
                    { 20, "Liz", "Kit", "Nursing" },
                    { 21, "Mat", "Tan", "Medicine" },
                    { 22, "Deb", "Roy", "Medicine" },
                    { 23, "Ana", "Ray", "Mining" },
                    { 24, "Lyn", "Poe", "Computing" },
                    { 25, "Amy", "Raj", "Nursing" },
                    { 26, "Kim", "Ash", "Mining" },
                    { 27, "Bec", "Kid", "Nursing" },
                    { 28, "Eva", "Fry", "Computing" },
                    { 29, "Eli", "Lap", "Business" },
                    { 30, "Sam", "Yim", "Nursing" },
                    { 31, "Joe", "Hui", "Mining" },
                    { 32, "Liz", "Jin", "Nursing" },
                    { 33, "Ric", "Kuo", "Business" },
                    { 34, "Pam", "Mak", "Computing" },
                    { 35, "Cat", "Yao", "Medicine" },
                    { 36, "Lou", "Zhu", "Mining" },
                    { 37, "Tom", "Dag", "Business" },
                    { 38, "Stu", "Day", "Business" },
                    { 39, "Tom", "Gad", "Mining" },
                    { 40, "Bob", "Bee", "Business" },
                    { 41, "Jim", "Ots", "Business" },
                    { 42, "Tom", "Mag", "Business" },
                    { 43, "Hal", "Doe", "Mining" },
                    { 44, "Roy", "Kim", "Mining" },
                    { 45, "Vis", "Cox", "Nursing" },
                    { 46, "Kay", "Aga", "Nursing" },
                    { 47, "Reo", "Hui", "Nursing" },
                    { 48, "Bob", "Roe", "Mining" },
                    { 49, "Jay", "Eff", "Computing" },
                    { 50, "Eva", "Chu", "Business" },
                    { 51, "Lex", "Rae", "Nursing" },
                    { 52, "Lin", "Dex", "Mining" },
                    { 53, "Tom", "Dag", "Business" },
                    { 54, "Ben", "Shy", "Computing" },
                    { 55, "Rob", "Bos", "Nursing" },
                    { 56, "Ali", "Mac", "Business" },
                    { 57, "Ken", "Sim", "Medicine" }
                });
        }
    }
}

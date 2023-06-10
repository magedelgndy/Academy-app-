using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "passeord",
                table: "Accounts",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Accounts",
                newName: "Password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Accounts",
                newName: "passeord");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Accounts",
                newName: "name");
        }
    }
}

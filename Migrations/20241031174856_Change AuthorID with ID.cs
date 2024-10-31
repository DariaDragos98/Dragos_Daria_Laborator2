using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dragos_Daria_Laborator2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAuthorIDwithID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "AuthorID");
        }
    }
}

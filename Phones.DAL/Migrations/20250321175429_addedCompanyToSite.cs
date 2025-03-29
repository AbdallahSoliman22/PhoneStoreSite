using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phones.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanyToSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Products",
                newName: "Company");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Products",
                newName: "Author");
        }
    }
}

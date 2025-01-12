using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JG.Task.Addition.Migrations
{
    /// <inheritdoc />
    public partial class Removal_of_name_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Calculations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

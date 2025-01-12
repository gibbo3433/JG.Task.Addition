using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JG.Task.Addition.Migrations
{
    /// <inheritdoc />
    public partial class Add_new_columkn_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Calculations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Calculations");
        }
    }
}

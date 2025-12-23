using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFormsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddFormPrefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "FormDefinitions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "FormDefinitions");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFormsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddMutuallyExclusiveWith : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MutuallyExclusiveWith",
                table: "FormFieldDefinitions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MutuallyExclusiveWith",
                table: "FormFieldDefinitions");
        }
    }
}

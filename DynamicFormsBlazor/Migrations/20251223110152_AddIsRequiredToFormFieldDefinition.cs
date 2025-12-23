using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFormsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRequiredToFormFieldDefinition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRequired",
                table: "FormFieldDefinitions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRequired",
                table: "FormFieldDefinitions");
        }
    }
}

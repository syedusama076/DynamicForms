using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFormsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddParentFieldKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "FormSubmissions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ParentFieldKey",
                table: "FormFieldDefinitions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "ParentFieldKey",
                table: "FormFieldDefinitions");
        }
    }
}

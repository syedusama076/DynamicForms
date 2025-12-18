using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFormsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToFormField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "FormFieldDefinitions",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "FormFieldDefinitions");
        }
    }
}

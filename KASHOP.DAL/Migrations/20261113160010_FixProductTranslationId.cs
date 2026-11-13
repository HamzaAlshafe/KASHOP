using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KASHOP.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixProductTranslationId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // SQL Server can't ALTER a column into IDENTITY,
            // so drop the old string Id and add a new int IDENTITY Id.
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductTranslations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductTranslations",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductTranslations");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ProductTranslations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations",
                column: "Id");
        }
    }
}
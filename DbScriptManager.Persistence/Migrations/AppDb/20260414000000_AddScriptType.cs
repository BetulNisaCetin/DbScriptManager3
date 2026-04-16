using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbScriptManager.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class AddScriptType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScriptType",
                table: "Scripts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "Script");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScriptType",
                table: "Scripts");
        }
    }
}

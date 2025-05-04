using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE491_Project.Migrations
{
    /// <inheritdoc />
    public partial class twiter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "twiter",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "twiter",
                table: "customers");
        }
    }
}

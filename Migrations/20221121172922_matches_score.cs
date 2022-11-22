using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RugbyManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class matchesscore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Score",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Matches");
        }
    }
}

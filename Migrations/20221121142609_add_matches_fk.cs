using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RugbyManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class addmatchesfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
            name: "FK_MatchesA_Teams_TeamsId",
            table: "Matches",
            column: "TeamAId",
            principalTable: "Teams",
            principalColumn: "Id",
            onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
            name: "FK_MatchesB_Teams_TeamsId",
            table: "Matches",
            column: "TeamBId",
            principalTable: "Teams",
            principalColumn: "Id",
            onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamHub_MVP.Data.Migrations
{
    public partial class AddTeamProjectsRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamID",
                table: "Projects",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamID",
                table: "Projects",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Projects");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamHub_MVP.Data.Migrations
{
    public partial class AddProjectToTeamBugsNotesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Bugs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ProjectID",
                table: "Notes",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ProjectID",
                table: "Bugs",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectID",
                table: "Bugs",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Projects_ProjectID",
                table: "Notes",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectID",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Projects_ProjectID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ProjectID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ProjectID",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Bugs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamHub_MVP.Data.Migrations
{
    public partial class AddLastRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerID",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReportedById",
                table: "Bugs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResolvedById",
                table: "Bugs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserWokringOnId",
                table: "Bugs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ReportedById",
                table: "Bugs",
                column: "ReportedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ResolvedById",
                table: "Bugs",
                column: "ResolvedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_UserWokringOnId",
                table: "Bugs",
                column: "UserWokringOnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_AspNetUsers_ReportedById",
                table: "Bugs",
                column: "ReportedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_AspNetUsers_ResolvedById",
                table: "Bugs",
                column: "ResolvedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_AspNetUsers_UserWokringOnId",
                table: "Bugs",
                column: "UserWokringOnId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_AspNetUsers_ReportedById",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_AspNetUsers_ResolvedById",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_AspNetUsers_UserWokringOnId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ReportedById",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ResolvedById",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_UserWokringOnId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ManagerID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ReportedById",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ResolvedById",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "UserWokringOnId",
                table: "Bugs");
        }
    }
}

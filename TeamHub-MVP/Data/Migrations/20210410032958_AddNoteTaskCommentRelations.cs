using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamHub_MVP.Data.Migrations
{
    public partial class AddNoteTaskCommentRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskID",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CreatedById",
                table: "Notes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_TaskID",
                table: "Notes",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedById",
                table: "Comments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TaskID",
                table: "Comments",
                column: "TaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById",
                table: "Comments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tasks_TaskID",
                table: "Comments",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AspNetUsers_CreatedById",
                table: "Notes",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Tasks_TaskID",
                table: "Notes",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tasks_TaskID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AspNetUsers_CreatedById",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Tasks_TaskID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CreatedById",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_TaskID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatedById",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TaskID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "TaskID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TaskID",
                table: "Comments");
        }
    }
}

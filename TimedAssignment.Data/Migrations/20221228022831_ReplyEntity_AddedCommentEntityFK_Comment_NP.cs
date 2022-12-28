using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimedAssignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReplyEntityAddedCommentEntityFKCommentNP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostIdId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_CommentIdId",
                table: "Replies");

            migrationBuilder.RenameColumn(
                name: "CommentIdId",
                table: "Replies",
                newName: "CommentEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentIdId",
                table: "Replies",
                newName: "IX_Replies_CommentEntityId");

            migrationBuilder.AlterColumn<int>(
                name: "PostIdId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostIdId",
                table: "Comments",
                column: "PostIdId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_CommentEntityId",
                table: "Replies",
                column: "CommentEntityId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostIdId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_CommentEntityId",
                table: "Replies");

            migrationBuilder.RenameColumn(
                name: "CommentEntityId",
                table: "Replies",
                newName: "CommentIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentEntityId",
                table: "Replies",
                newName: "IX_Replies_CommentIdId");

            migrationBuilder.AlterColumn<int>(
                name: "PostIdId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostIdId",
                table: "Comments",
                column: "PostIdId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_CommentIdId",
                table: "Replies",
                column: "CommentIdId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

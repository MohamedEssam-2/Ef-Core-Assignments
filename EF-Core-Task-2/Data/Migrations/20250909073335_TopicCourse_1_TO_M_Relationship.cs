using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Task_2.Data.Migrations
{
    /// <inheritdoc />
    public partial class TopicCourse_1_TO_M_Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_id",
                table: "Courses",
                column: "Top_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_Top_id",
                table: "Courses",
                column: "Top_id",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_Top_id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_id",
                table: "Courses");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Task_2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_2_RelationsBetween_DepAndIns_1_to_M_WorkRelationShip_And_Mange_1_to_1_RelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ins_id",
                table: "Departments",
                newName: "Ins_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Ins_Id",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dep_id",
                table: "Instructors",
                column: "Dep_id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                unique: true,
                filter: "[Ins_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dep_id",
                table: "Instructors",
                column: "Dep_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dep_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dep_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Ins_Id",
                table: "Departments",
                newName: "Ins_id");

            migrationBuilder.AlterColumn<int>(
                name: "Ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

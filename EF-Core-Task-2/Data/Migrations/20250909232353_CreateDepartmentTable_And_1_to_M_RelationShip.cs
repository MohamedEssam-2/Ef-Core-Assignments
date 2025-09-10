using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Task_2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDepartmentTable_And_1_to_M_RelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Ins_id = table.Column<int>(type: "int", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_id",
                table: "Students",
                column: "Dep_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_id",
                table: "Students",
                column: "Dep_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_id",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_id",
                table: "Students");
        }
    }
}

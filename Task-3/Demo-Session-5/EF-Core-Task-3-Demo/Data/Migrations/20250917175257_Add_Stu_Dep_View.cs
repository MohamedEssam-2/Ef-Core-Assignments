using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Task_3_Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Stu_Dep_View : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create or alter view Stu_Dep_Veiw
             with encryption 
             as 
             select CONCAT_WS(',', s.FName, s.LName) AS [Student_Name],
                       d.Name AS [Dep_Name],
                       d.Id AS [Dep_Id]
             from Students s , Departments d 
             where d.Id = s.Dep_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop view Stu_Dep_Veiw");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_departmentid",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_departmentid",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_departmentid",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Courses_departmentid",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Trainees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "img",
                table: "Trainees",
                newName: "Img");

            migrationBuilder.RenameColumn(
                name: "grade",
                table: "Trainees",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "dept_id",
                table: "Trainees",
                newName: "Dept_id");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Trainees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Trainees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "Instructors",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Instructors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "img",
                table: "Instructors",
                newName: "Img");

            migrationBuilder.RenameColumn(
                name: "dept_id",
                table: "Instructors",
                newName: "Dept_id");

            migrationBuilder.RenameColumn(
                name: "crs_id",
                table: "Instructors",
                newName: "Crs_id");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Instructors",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Instructors",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_dept_id",
                table: "Instructors",
                newName: "IX_Instructors_Dept_id");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors",
                newName: "IX_Instructors_Crs_id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "manager",
                table: "Departments",
                newName: "Manager");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Departments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Courses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "min_degree",
                table: "Courses",
                newName: "Min_degree");

            migrationBuilder.RenameColumn(
                name: "dept_id",
                table: "Courses",
                newName: "Dept_id");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Courses",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Courses",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_Dept_id",
                table: "Trainees",
                column: "Dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Dept_id",
                table: "Courses",
                column: "Dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Dept_id",
                table: "Courses",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_Crs_id",
                table: "Instructors",
                column: "Crs_id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Dept_id",
                table: "Trainees",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Dept_id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_Crs_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_Dept_id",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_Dept_id",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Dept_id",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trainees",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Trainees",
                newName: "img");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Trainees",
                newName: "grade");

            migrationBuilder.RenameColumn(
                name: "Dept_id",
                table: "Trainees",
                newName: "dept_id");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Trainees",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trainees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Instructors",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Instructors",
                newName: "img");

            migrationBuilder.RenameColumn(
                name: "Dept_id",
                table: "Instructors",
                newName: "dept_id");

            migrationBuilder.RenameColumn(
                name: "Crs_id",
                table: "Instructors",
                newName: "crs_id");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Instructors",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructors",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dept_id",
                table: "Instructors",
                newName: "IX_Instructors_dept_id");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Crs_id",
                table: "Instructors",
                newName: "IX_Instructors_crs_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Manager",
                table: "Departments",
                newName: "manager");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Min_degree",
                table: "Courses",
                newName: "min_degree");

            migrationBuilder.RenameColumn(
                name: "Dept_id",
                table: "Courses",
                newName: "dept_id");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Courses",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_departmentid",
                table: "Trainees",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_departmentid",
                table: "Courses",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_departmentid",
                table: "Courses",
                column: "departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors",
                column: "crs_id",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors",
                column: "dept_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_departmentid",
                table: "Trainees",
                column: "departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}

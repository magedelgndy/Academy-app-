using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_courseid",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_departmentid",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_courseid",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_departmentid",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "courseid",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "Instructors");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_dept_id",
                table: "Instructors",
                column: "dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors",
                column: "crs_id",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors",
                column: "dept_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_dept_id",
                table: "Instructors");

            migrationBuilder.AddColumn<int>(
                name: "courseid",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_courseid",
                table: "Instructors",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_departmentid",
                table: "Instructors",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_courseid",
                table: "Instructors",
                column: "courseid",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_departmentid",
                table: "Instructors",
                column: "departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

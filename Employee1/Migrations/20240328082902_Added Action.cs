using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee1.Migrations
{
    public partial class AddedAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dateofbirth",
                table: "Empoyees",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "ContactNO",
                table: "Empoyees",
                newName: "ContactNo");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Empoyees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Empoyees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Empoyees");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Empoyees",
                newName: "Dateofbirth");

            migrationBuilder.RenameColumn(
                name: "ContactNo",
                table: "Empoyees",
                newName: "ContactNO");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Empoyees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}

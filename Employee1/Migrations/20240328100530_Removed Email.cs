using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee1.Migrations
{
    public partial class RemovedEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Empoyees");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Empoyees",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Empoyees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Empoyees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

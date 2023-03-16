using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM.DATA.Migrations
{
    public partial class SetDefaultAccountPin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Accountpin",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "0000",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Accountpin",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "0000");
        }
    }
}

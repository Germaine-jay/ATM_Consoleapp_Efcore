using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM.DATA.Migrations
{
    public partial class AddTransactiondecision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "Transactions",
                newName: "Account");

            migrationBuilder.AddColumn<string>(
                name: "TransactionDiscription",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDiscription",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Account",
                table: "Transactions",
                newName: "AccountNumber");

            migrationBuilder.AddColumn<long>(
                name: "Balance",
                table: "Transactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}

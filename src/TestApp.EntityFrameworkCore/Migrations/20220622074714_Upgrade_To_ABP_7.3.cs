using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.Migrations
{
    public partial class Upgrade_To_ABP_73 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TargetNotifiers",
                table: "AbpUserNotifications",
                type: "varchar(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetNotifiers",
                table: "AbpNotifications",
                type: "varchar(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetNotifiers",
                table: "AbpUserNotifications");

            migrationBuilder.DropColumn(
                name: "TargetNotifiers",
                table: "AbpNotifications");
        }
    }
}

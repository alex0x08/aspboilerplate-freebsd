using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class Upgrade_To_ABP_6_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PropertyName",
                table: "AbpDynamicProperties",
                type: "varchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntityFullName",
                table: "AbpDynamicEntityProperties",
                type: "varchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExceptionMessage",
                table: "AbpAuditLogs",
                type: "varchar(1024)",
                maxLength: 1024,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExceptionMessage",
                table: "AbpAuditLogs");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyName",
                table: "AbpDynamicProperties",
                type: "varchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntityFullName",
                table: "AbpDynamicEntityProperties",
                type: "varchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}

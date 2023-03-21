using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class Upgraded_To_ABP_6_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewValueHash",
                table: "AbpEntityPropertyChanges",
                type: "varchar(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalValueHash",
                table: "AbpEntityPropertyChanges",
                type: "varchar(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AbpDynamicProperties",
                type: "varchar(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewValueHash",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropColumn(
                name: "OriginalValueHash",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AbpDynamicProperties");
        }
    }
}

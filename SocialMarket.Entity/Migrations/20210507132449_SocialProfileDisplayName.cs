using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMarket.Entity.Migrations
{
    public partial class SocialProfileDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "SocialProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "SocialProfile",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "SocialProfile");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "SocialProfile");
        }
    }
}

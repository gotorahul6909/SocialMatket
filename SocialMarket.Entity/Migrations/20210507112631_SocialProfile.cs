using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMarket.Entity.Migrations
{
    public partial class SocialProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialProfile",
                columns: table => new
                {
                    SocialProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialProfile", x => x.SocialProfileId);
                });

            migrationBuilder.InsertData(
                table: "SocialProfile",
                columns: new[] { "SocialProfileId", "Name" },
                values: new object[] { 1, "Facebook" });

            migrationBuilder.InsertData(
                table: "SocialProfile",
                columns: new[] { "SocialProfileId", "Name" },
                values: new object[] { 2, "LinkedIn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialProfile");
        }
    }
}

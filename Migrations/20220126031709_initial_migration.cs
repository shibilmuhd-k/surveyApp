using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechSurvey",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    question = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    createdDate = table.Column<string>(nullable: true),
                    updateDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechSurveys", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechSurvey");
        }
    }
}

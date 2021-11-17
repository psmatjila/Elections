using Microsoft.EntityFrameworkCore.Migrations;

namespace Elections.Migrations
{
    public partial class ElectionsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NovElections",
                columns: table => new
                {
                    PartyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyAbbr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovElections", x => x.PartyName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NovElections");
        }
    }
}

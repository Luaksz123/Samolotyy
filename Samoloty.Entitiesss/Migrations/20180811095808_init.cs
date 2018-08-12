using Microsoft.EntityFrameworkCore.Migrations;

namespace Samoloty.Entitiesss.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loty", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rezerwacjes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacjes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Samoloty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samoloty", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loty");

            migrationBuilder.DropTable(
                name: "Rezerwacjes");

            migrationBuilder.DropTable(
                name: "Samoloty");
        }
    }
}

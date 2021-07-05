using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkLookUpAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    IsOpen = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "City", "IsOpen", "Name", "State" },
                values: new object[,]
                {
                    { 1, 2219789, "West Yellowstone", true, "Yellow Stone", "Wyoming" },
                    { 2, 265461, "Estes Park", true, "Rocky Moutain", "Colorado" },
                    { 3, 183224, "Klamath Falls", false, "Crater Lake", "Oregon" },
                    { 4, 236381, "Tacoma", true, "Mount Rainier", "Washington" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}

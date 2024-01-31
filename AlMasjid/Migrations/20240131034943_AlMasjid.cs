using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlMasjid.Migrations
{
    /// <inheritdoc />
    public partial class AlMasjid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mosques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Fajr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duhr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Magrib = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mosques", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mosques");
        }
    }
}

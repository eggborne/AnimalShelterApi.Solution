using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, "Chihuahua", "Male", "Conan", "dog" },
                    { 2, "ShortHair", "Female", "Curtesia", "cat" },
                    { 3, "GoldenRetriever", "Male", "Chauncey", "dog" },
                    { 4, "ShortHair", "Male", "Curtis", "cat" },
                    { 5, "Corgi", "Female", "Ginger", "dog" },
                    { 6, "Corgi", "Male", "Winston", "dog" },
                    { 7, "Siamese", "Male", "Sugar", "cat" },
                    { 8, "Airedale", "Female", "Valerie", "dog" },
                    { 9, "LongHair", "Male", "Mingus", "cat" },
                    { 10, "Dachshund", "Male", "Dexter", "dog" },
                    { 11, "ShortHair", "Male", "Mingus", "cat" },
                    { 12, "Boxer", "Female", "Jasmine", "dog" },
                    { 13, "Siamese", "Male", "Linus", "cat" },
                    { 14, "Beagle", "Female", "Petunia", "dog" },
                    { 15, "Bulldog", "Male", "Tiny", "dog" },
                    { 16, "ShortHair", "Female", "Minnie", "cat" },
                    { 17, "ShortHair", "Male", "Marvin", "cat" },
                    { 18, "Pomeranian", "Male", "Fizzgig", "dog" },
                    { 19, "LongHair", "Male", "Wolfie", "cat" },
                    { 20, "Husky", "Female", "Pandora", "dog" },
                    { 21, "ShihTzu", "Male", "Batman", "dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}

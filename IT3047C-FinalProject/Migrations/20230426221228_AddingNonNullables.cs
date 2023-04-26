using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProject.Migrations
{
    public partial class AddingNonNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hobbyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recommendedHobby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecHobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RecHobbies",
                columns: new[] { "Id", "Name", "hobbyType", "recommendedHobby", "userName" },
                values: new object[] { 1, "Example here", "Computers", "Practice coding", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecHobbies");
        }
    }
}

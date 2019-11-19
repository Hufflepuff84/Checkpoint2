using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Owner = table.Column<string>(maxLength: 75, nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Owner", "Type", "Name" },
                values: new object[] { 1, "Bob Martinez", "Mexican", "Great Tacos" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Owner", "Type", "Name" },
                values: new object[] { 2, "Michael Khan", "Thai", "Delicious Thai Meals" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Owner", "Type", "Name" },
                values: new object[] { 3, "Raj Biswanathan", "Indian", "South Asian Treats" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
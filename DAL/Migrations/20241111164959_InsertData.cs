using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Storage",
                table: "Storage");

            migrationBuilder.RenameTable(
                name: "Storage",
                newName: "Storages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "The Great Dictator" },
                    { 2, "Cinema Paradiso" },
                    { 3, "The Lives of Others" },
                    { 4, "Grave of the Fireflies" },
                    { 5, "Paths of Glory" },
                    { 6, "Django Unchained" },
                    { 7, "The Shining" },
                    { 8, "WALL·E" },
                    { 9, "American Beauty" },
                    { 10, "The Dark Knight Rises" },
                    { 11, "Princess Mononoke" },
                    { 12, "Aliens" },
                    { 13, "Oldboy" },
                    { 14, "Once Upon a Time in America" },
                    { 15, "Witness for the Prosecution" },
                    { 16, "Das Boot" },
                    { 17, "Citizen Kane" },
                    { 18, "North by Northwest" },
                    { 19, "Vertigo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.RenameTable(
                name: "Storages",
                newName: "Storage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storage",
                table: "Storage",
                column: "Id");
        }
    }
}

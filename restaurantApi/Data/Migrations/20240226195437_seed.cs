using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace restaurantApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "plat",
                columns: new[] { "id", "images", "name", "prix" },
                values: new object[,]
                {
                    { 1, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 1", 10 },
                    { 2, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 2", 20 },
                    { 3, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 3", 30 },
                    { 4, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 4", 40 },
                    { 5, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 5", 50 },
                    { 6, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 6", 60 },
                    { 7, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 7", 70 },
                    { 8, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 8", 80 },
                    { 9, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 9", 90 },
                    { 10, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 10", 100 },
                    { 11, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 11", 110 },
                    { 12, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 12", 120 },
                    { 13, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 13", 130 },
                    { 14, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 14", 140 },
                    { 15, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 15", 150 },
                    { 16, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 16", 160 },
                    { 17, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 17", 170 },
                    { 18, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 18", 180 },
                    { 19, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 19", 190 },
                    { 20, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 20", 200 },
                    { 21, "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg", "Plat 21", 210 },
                    { 22, "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg", "Plat 22", 220 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "plat",
                keyColumn: "id",
                keyValue: 22);
        }
    }
}

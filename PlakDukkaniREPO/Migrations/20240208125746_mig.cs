using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkaniREPO.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                columns: new[] { "Adi", "CreatedDate", "Sanatci" },
                values: new object[] { "Album 1", new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3178), "Sanatci 1" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 2,
                columns: new[] { "Adi", "CikisTarihi", "CreatedDate", "Sanatci" },
                values: new object[] { "Album 2", new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3192), "Sanatci 2" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "Adi", "CikisTarihi", "CreatedDate", "DeletedDate", "DukkanID", "Fiyati", "IndirimOrani", "Sanatci", "SatisDevamMi", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Album 3", new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3195), null, 1, 750.0, 0.0, "Sanatci 3", false, 0, null },
                    { 4, "Album 4", new DateTime(1945, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3197), null, 1, 750.0, 25.0, "Sanatci 4", true, 0, null },
                    { 5, "Album 5", new DateTime(1932, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3198), null, 1, 750.0, 0.0, "Sanatci 5", false, 0, null },
                    { 6, "Album 6", new DateTime(1912, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3199), null, 1, 750.0, 15.0, "Sanatci 6", true, 0, null },
                    { 7, "Album 7", new DateTime(1999, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3201), null, 1, 750.0, 0.0, "Sanatci 7", true, 0, null },
                    { 8, "Album 8", new DateTime(2000, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3202), null, 1, 750.0, 20.0, "Sanatci 8", false, 0, null },
                    { 9, "Album 9", new DateTime(1965, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3203), null, 1, 750.0, 25.0, "Sanatci 9", true, 0, null },
                    { 10, "Album 10", new DateTime(1970, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3204), null, 1, 750.0, 50.0, "Sanatci 10", true, 0, null },
                    { 11, "Album 11", new DateTime(1920, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3206), null, 1, 750.0, 30.0, "Sanatc 11", true, 0, null },
                    { 12, "Album 12", new DateTime(1925, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3207), null, 1, 750.0, 10.0, "Sanatci 12", true, 0, null },
                    { 13, "Album 13", new DateTime(2005, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(3208), null, 1, 750.0, 0.0, "Sanatci 13", true, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Dukkans",
                keyColumn: "DukkanID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Yoneticis",
                keyColumn: "YoneticiID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "KullaniciAdi", "Password" },
                values: new object[] { new DateTime(2024, 2, 8, 15, 57, 46, 829, DateTimeKind.Local).AddTicks(6531), "a", "a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                columns: new[] { "Adi", "CreatedDate", "Sanatci" },
                values: new object[] { "Adını Kalbime Yaz", new DateTime(2024, 2, 6, 14, 43, 18, 504, DateTimeKind.Local).AddTicks(9920), "Tarkan" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 2,
                columns: new[] { "Adi", "CikisTarihi", "CreatedDate", "Sanatci" },
                values: new object[] { "Help", new DateTime(1965, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 14, 43, 18, 504, DateTimeKind.Local).AddTicks(9933), "Beatles" });

            migrationBuilder.UpdateData(
                table: "Dukkans",
                keyColumn: "DukkanID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 14, 43, 18, 505, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Yoneticis",
                keyColumn: "YoneticiID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "KullaniciAdi", "Password" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 43, 18, 505, DateTimeKind.Local).AddTicks(973), "Fatih", "Fatih1962" });
        }
    }
}

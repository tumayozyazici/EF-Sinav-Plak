using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkaniREPO.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dukkans",
                columns: table => new
                {
                    DukkanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dukkans", x => x.DukkanID);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sanatci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyati = table.Column<double>(type: "float", nullable: false),
                    IndirimOrani = table.Column<double>(type: "float", nullable: true),
                    SatisDevamMi = table.Column<bool>(type: "bit", nullable: false),
                    DukkanID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                    table.ForeignKey(
                        name: "FK_Albums_Dukkans_DukkanID",
                        column: x => x.DukkanID,
                        principalTable: "Dukkans",
                        principalColumn: "DukkanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticis",
                columns: table => new
                {
                    YoneticiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DukkanID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticis", x => x.YoneticiID);
                    table.ForeignKey(
                        name: "FK_Yoneticis_Dukkans_DukkanID",
                        column: x => x.DukkanID,
                        principalTable: "Dukkans",
                        principalColumn: "DukkanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dukkans",
                columns: new[] { "DukkanID", "Adi", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { 1, "Eskiler", new DateTime(2024, 2, 6, 14, 43, 18, 505, DateTimeKind.Local).AddTicks(614), null, 0, null });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "Adi", "CikisTarihi", "CreatedDate", "DeletedDate", "DukkanID", "Fiyati", "IndirimOrani", "Sanatci", "SatisDevamMi", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Adını Kalbime Yaz", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 14, 43, 18, 504, DateTimeKind.Local).AddTicks(9920), null, 1, 250.0, 15.0, "Tarkan", true, 0, null },
                    { 2, "Help", new DateTime(1965, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 14, 43, 18, 504, DateTimeKind.Local).AddTicks(9933), null, 1, 750.0, 25.0, "Beatles", true, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Yoneticis",
                columns: new[] { "YoneticiID", "CreatedDate", "DeletedDate", "DukkanID", "KullaniciAdi", "Password", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 2, 6, 14, 43, 18, 505, DateTimeKind.Local).AddTicks(973), null, 1, "Fatih", "Fatih1962", 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_DukkanID",
                table: "Albums",
                column: "DukkanID");

            migrationBuilder.CreateIndex(
                name: "IX_Yoneticis_DukkanID",
                table: "Yoneticis",
                column: "DukkanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Yoneticis");

            migrationBuilder.DropTable(
                name: "Dukkans");
        }
    }
}

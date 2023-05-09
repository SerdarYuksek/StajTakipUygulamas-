using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicis", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "stajBilgis",
                columns: table => new
                {
                    StajBilgiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdUnvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alanı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaksNo = table.Column<int>(type: "int", nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Başlamatrh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bitistrh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StajTürü = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResmiTatil = table.Column<bool>(type: "bit", nullable: false),
                    CmtDahil = table.Column<bool>(type: "bit", nullable: false),
                    Egitim = table.Column<bool>(type: "bit", nullable: false),
                    KabulGün = table.Column<int>(type: "int", nullable: false),
                    Onay = table.Column<bool>(type: "bit", nullable: false),
                    Kabul = table.Column<bool>(type: "bit", nullable: false),
                    KatkıPayıOnay = table.Column<bool>(type: "bit", nullable: false),
                    RedSebep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StajBilgiStatus = table.Column<bool>(type: "bit", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stajBilgis", x => x.StajBilgiID);
                    table.ForeignKey(
                        name: "FK_stajBilgis_kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "kullanicis",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_stajBilgis_KullaniciID",
                table: "stajBilgis",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stajBilgis");

            migrationBuilder.DropTable(
                name: "kullanicis");
        }
    }
}

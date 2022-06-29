using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "about2s",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balik1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resimURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about2s", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resimURL1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baslik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "altHakkindas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_altHakkindas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KonaklamaSuresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiyat = table.Column<double>(type: "float", nullable: false),
                    resimURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kapasite = table.Column<int>(type: "int", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "iletisims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Harita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "onecikanlar2s",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post2Baslıgı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post2Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post2Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post2Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_onecikanlar2s", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "oneCikanlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post1Baslıgı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oneCikanlars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "referanslars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    müsteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ımageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referanslars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "reshberlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twitterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reshberlers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "yeniHaberlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yeniHaberlers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "about2s");

            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "altHakkindas");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "iletisims");

            migrationBuilder.DropTable(
                name: "onecikanlar2s");

            migrationBuilder.DropTable(
                name: "oneCikanlars");

            migrationBuilder.DropTable(
                name: "referanslars");

            migrationBuilder.DropTable(
                name: "reshberlers");

            migrationBuilder.DropTable(
                name: "yeniHaberlers");
        }
    }
}

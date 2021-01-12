using Microsoft.EntityFrameworkCore.Migrations;

namespace Webonline.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaSinhVien",
                columns: table => new
                {
                    IdKhoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaSinhVien", x => x.IdKhoa);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    ID_Mon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMonHoc = table.Column<string>(maxLength: 50, nullable: false),
                    IdKhoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.ID_Mon);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MaSV = table.Column<string>(nullable: true),
                    IdKhoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.id);
                    table.ForeignKey(
                        name: "FK_SinhViens_KhoaSinhVien_IdKhoa",
                        column: x => x.IdKhoa,
                        principalTable: "KhoaSinhVien",
                        principalColumn: "IdKhoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHocKhoa",
                columns: table => new
                {
                    MonhocID = table.Column<int>(nullable: false),
                    KhoaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocKhoa", x => new { x.KhoaID, x.MonhocID });
                    table.ForeignKey(
                        name: "FK_MonHocKhoa_KhoaSinhVien_KhoaID",
                        column: x => x.KhoaID,
                        principalTable: "KhoaSinhVien",
                        principalColumn: "IdKhoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonHocKhoa_MonHoc_MonhocID",
                        column: x => x.MonhocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID_Mon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHocSinhVien",
                columns: table => new
                {
                    SinhvienId = table.Column<int>(nullable: false),
                    Id_Mon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocSinhVien", x => new { x.Id_Mon, x.SinhvienId });
                    table.ForeignKey(
                        name: "FK_MonHocSinhVien_MonHoc_Id_Mon",
                        column: x => x.Id_Mon,
                        principalTable: "MonHoc",
                        principalColumn: "ID_Mon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonHocSinhVien_SinhViens_SinhvienId",
                        column: x => x.SinhvienId,
                        principalTable: "SinhViens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonHocKhoa_MonhocID",
                table: "MonHocKhoa",
                column: "MonhocID");

            migrationBuilder.CreateIndex(
                name: "IX_MonHocSinhVien_SinhvienId",
                table: "MonHocSinhVien",
                column: "SinhvienId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_IdKhoa",
                table: "SinhViens",
                column: "IdKhoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonHocKhoa");

            migrationBuilder.DropTable(
                name: "MonHocSinhVien");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "KhoaSinhVien");
        }
    }
}

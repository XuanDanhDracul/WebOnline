using Microsoft.EntityFrameworkCore.Migrations;

namespace Webonline.Data.Migrations
{
    public partial class SeenData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KhoaSinhVien",
                columns: new[] { "IdKhoa", "TenKhoa" },
                values: new object[,]
                {
                    { 123, "KhoaCNTT" },
                    { 124, "KhoaCNSinhHoc" },
                    { 125, "KhoaHoa" }
                });

            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "ID_Mon", "IdKhoa", "TenMonHoc" },
                values: new object[,]
                {
                    { 345, 123, "Toan" },
                    { 245, 123, "Van" },
                    { 145, 125, "Hoa" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "id", "IdKhoa", "MaSV", "Name" },
                values: new object[] { 1, 123, "12345", "Danh" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "id", "IdKhoa", "MaSV", "Name" },
                values: new object[] { 3, 123, "1234", "Hung" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "id", "IdKhoa", "MaSV", "Name" },
                values: new object[] { 2, 124, "123456", "Nam" });

            migrationBuilder.InsertData(
                table: "MonHocSinhVien",
                columns: new[] { "Id_Mon", "SinhvienId" },
                values: new object[] { 345, 1 });

            migrationBuilder.InsertData(
                table: "MonHocSinhVien",
                columns: new[] { "Id_Mon", "SinhvienId" },
                values: new object[] { 345, 3 });

            migrationBuilder.InsertData(
                table: "MonHocSinhVien",
                columns: new[] { "Id_Mon", "SinhvienId" },
                values: new object[] { 345, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KhoaSinhVien",
                keyColumn: "IdKhoa",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "MonHocSinhVien",
                keyColumns: new[] { "Id_Mon", "SinhvienId" },
                keyValues: new object[] { 345, 1 });

            migrationBuilder.DeleteData(
                table: "MonHocSinhVien",
                keyColumns: new[] { "Id_Mon", "SinhvienId" },
                keyValues: new object[] { 345, 2 });

            migrationBuilder.DeleteData(
                table: "MonHocSinhVien",
                keyColumns: new[] { "Id_Mon", "SinhvienId" },
                keyValues: new object[] { 345, 3 });

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KhoaSinhVien",
                keyColumn: "IdKhoa",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "KhoaSinhVien",
                keyColumn: "IdKhoa",
                keyValue: 124);
        }
    }
}

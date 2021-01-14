using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webonline.Data.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonHocKhoa_KhoaSinhVien_KhoaID",
                table: "MonHocKhoa");

            migrationBuilder.DropForeignKey(
                name: "FK_MonHocSinhVien_SinhViens_SinhvienId",
                table: "MonHocSinhVien");

            migrationBuilder.DropForeignKey(
                name: "FK_SinhViens_KhoaSinhVien_IdKhoa",
                table: "SinhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SinhViens",
                table: "SinhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhoaSinhVien",
                table: "KhoaSinhVien");

            migrationBuilder.DropColumn(
                name: "IdKhoa",
                table: "MonHoc");

            migrationBuilder.RenameTable(
                name: "SinhViens",
                newName: "SinhVien");

            migrationBuilder.RenameTable(
                name: "KhoaSinhVien",
                newName: "Khoa");

            migrationBuilder.RenameColumn(
                name: "TenMonHoc",
                table: "MonHoc",
                newName: "Ten_MH");

            migrationBuilder.RenameIndex(
                name: "IX_SinhViens_IdKhoa",
                table: "SinhVien",
                newName: "IX_SinhVien_IdKhoa");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SinhVien",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaSV",
                table: "SinhVien",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "SinhVien",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "viewCout",
                table: "SinhVien",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TenKhoa",
                table: "Khoa",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "KhoaID",
                table: "Khoa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SinhVien",
                table: "SinhVien",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Khoa",
                table: "Khoa",
                column: "IdKhoa");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(nullable: false),
                    path = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: false),
                    Isdefault = table.Column<bool>(nullable: false),
                    CreateIma = table.Column<DateTime>(nullable: false),
                    SortImage = table.Column<int>(maxLength: 200, nullable: false),
                    FileSize = table.Column<int>(maxLength: 200, nullable: false),
                    AppUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.id);
                    table.ForeignKey(
                        name: "FK_Images_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_SinhVien_productID",
                        column: x => x.productID,
                        principalTable: "SinhVien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3"), "2b809757-7eb6-434f-b861-a2eeb578511f", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "firstname", "lastname" },
                values: new object[] { new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"), 0, "3323de48-8a47-400d-aa0e-fffd9bfc5f1c", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "XuanDanh@gmail.com", true, false, null, "xuandanh@gmail.com", "admin", "AQAAAAEAACcQAAAAEKL24j8TX8JxCIAmUmeHr592V3168F0dBL4WGu1oUj6w2HWKY8+0EzLpyrXzoSkugg==", null, false, "", false, "admin", "Xuan", "Danh" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"), new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3") });

            migrationBuilder.UpdateData(
                table: "SinhVien",
                keyColumn: "id",
                keyValue: 1,
                column: "viewCout",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SinhVien",
                keyColumn: "id",
                keyValue: 2,
                column: "viewCout",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SinhVien",
                keyColumn: "id",
                keyValue: 3,
                column: "viewCout",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AppUserId",
                table: "Images",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_productID",
                table: "Images",
                column: "productID");

            migrationBuilder.AddForeignKey(
                name: "FK_MonHocKhoa_Khoa_KhoaID",
                table: "MonHocKhoa",
                column: "KhoaID",
                principalTable: "Khoa",
                principalColumn: "IdKhoa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonHocSinhVien_SinhVien_SinhvienId",
                table: "MonHocSinhVien",
                column: "SinhvienId",
                principalTable: "SinhVien",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVien_Khoa_IdKhoa",
                table: "SinhVien",
                column: "IdKhoa",
                principalTable: "Khoa",
                principalColumn: "IdKhoa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonHocKhoa_Khoa_KhoaID",
                table: "MonHocKhoa");

            migrationBuilder.DropForeignKey(
                name: "FK_MonHocSinhVien_SinhVien_SinhvienId",
                table: "MonHocSinhVien");

            migrationBuilder.DropForeignKey(
                name: "FK_SinhVien_Khoa_IdKhoa",
                table: "SinhVien");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SinhVien",
                table: "SinhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Khoa",
                table: "Khoa");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ea0e744c-d96d-4fc3-acd2-19d3eb7f5533"), new Guid("5e848d75-9a0e-40c3-a1ce-e7d0116482b3") });

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "SinhVien");

            migrationBuilder.DropColumn(
                name: "viewCout",
                table: "SinhVien");

            migrationBuilder.DropColumn(
                name: "KhoaID",
                table: "Khoa");

            migrationBuilder.RenameTable(
                name: "SinhVien",
                newName: "SinhViens");

            migrationBuilder.RenameTable(
                name: "Khoa",
                newName: "KhoaSinhVien");

            migrationBuilder.RenameColumn(
                name: "Ten_MH",
                table: "MonHoc",
                newName: "TenMonHoc");

            migrationBuilder.RenameIndex(
                name: "IX_SinhVien_IdKhoa",
                table: "SinhViens",
                newName: "IX_SinhViens_IdKhoa");

            migrationBuilder.AddColumn<int>(
                name: "IdKhoa",
                table: "MonHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MaSV",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TenKhoa",
                table: "KhoaSinhVien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SinhViens",
                table: "SinhViens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhoaSinhVien",
                table: "KhoaSinhVien",
                column: "IdKhoa");

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 145,
                column: "IdKhoa",
                value: 125);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 245,
                column: "IdKhoa",
                value: 123);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "ID_Mon",
                keyValue: 345,
                column: "IdKhoa",
                value: 123);

            migrationBuilder.AddForeignKey(
                name: "FK_MonHocKhoa_KhoaSinhVien_KhoaID",
                table: "MonHocKhoa",
                column: "KhoaID",
                principalTable: "KhoaSinhVien",
                principalColumn: "IdKhoa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonHocSinhVien_SinhViens_SinhvienId",
                table: "MonHocSinhVien",
                column: "SinhvienId",
                principalTable: "SinhViens",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SinhViens_KhoaSinhVien_IdKhoa",
                table: "SinhViens",
                column: "IdKhoa",
                principalTable: "KhoaSinhVien",
                principalColumn: "IdKhoa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

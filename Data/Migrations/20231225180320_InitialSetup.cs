using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuliahkuApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Nim = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama_Mhs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tgl_Lahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Nim);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

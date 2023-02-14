using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PdfToXml.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PdfFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PdfFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XmlFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    XmlFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    File1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    File2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadedFiles");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    File1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    File2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdfFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PdfFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XmlFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    XmlFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });
        }
    }
}

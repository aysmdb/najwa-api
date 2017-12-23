using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace NajwaApi.Migrations
{
    public partial class transaksiakun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransaksiAkun",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AkunId = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<int>(type: "int4", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaksiAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransaksiAkun_Akun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "Akun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiAkun_AkunId",
                table: "TransaksiAkun",
                column: "AkunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransaksiAkun");
        }
    }
}

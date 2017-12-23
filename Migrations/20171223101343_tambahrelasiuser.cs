using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace NajwaApi.Migrations
{
    public partial class tambahrelasiuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "TransaksiAkun",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiAkun_UserId1",
                table: "TransaksiAkun",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TransaksiAkun_AspNetUsers_UserId1",
                table: "TransaksiAkun",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransaksiAkun_AspNetUsers_UserId1",
                table: "TransaksiAkun");

            migrationBuilder.DropIndex(
                name: "IX_TransaksiAkun_UserId1",
                table: "TransaksiAkun");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "TransaksiAkun");
        }
    }
}

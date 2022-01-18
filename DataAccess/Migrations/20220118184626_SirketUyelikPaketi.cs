using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SirketUyelikPaketi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UyelikPaketiId",
                table: "Sirketler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sirketler_UyelikPaketiId",
                table: "Sirketler",
                column: "UyelikPaketiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sirketler_UyelikPaketleri_UyelikPaketiId",
                table: "Sirketler",
                column: "UyelikPaketiId",
                principalTable: "UyelikPaketleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sirketler_UyelikPaketleri_UyelikPaketiId",
                table: "Sirketler");

            migrationBuilder.DropIndex(
                name: "IX_Sirketler_UyelikPaketiId",
                table: "Sirketler");

            migrationBuilder.DropColumn(
                name: "UyelikPaketiId",
                table: "Sirketler");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiExample.Migrations
{
    /// <inheritdoc />
    public partial class cambie_el_nombre_de_la_entidad_Owners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_Owners_OwnerId",
                table: "vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "owners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners",
                table: "owners",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_owners_OwnerId",
                table: "vehicles",
                column: "OwnerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_owners_OwnerId",
                table: "vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners",
                table: "owners");

            migrationBuilder.RenameTable(
                name: "owners",
                newName: "Owners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_Owners_OwnerId",
                table: "vehicles",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

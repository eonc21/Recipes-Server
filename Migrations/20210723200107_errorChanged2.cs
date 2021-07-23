using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes_Server.Migrations
{
    public partial class errorChanged2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Recipes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId1",
                table: "Recipes",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId1",
                table: "Recipes",
                column: "CategoryId1",
                principalTable: "CategoryReadDTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Recipes");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "CategoryReadDTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

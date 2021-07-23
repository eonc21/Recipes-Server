using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Recipes_Server.Migrations
{
    public partial class errorChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryName",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryReadDTO",
                table: "CategoryReadDTO");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Recipes",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_CategoryName",
                table: "Recipes",
                newName: "IX_Recipes_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CategoryReadDTO",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryReadDTO",
                table: "CategoryReadDTO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "CategoryReadDTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryReadDTO",
                table: "CategoryReadDTO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CategoryReadDTO");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Recipes",
                newName: "CategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                newName: "IX_Recipes_CategoryName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryReadDTO",
                table: "CategoryReadDTO",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryReadDTO_CategoryName",
                table: "Recipes",
                column: "CategoryName",
                principalTable: "CategoryReadDTO",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

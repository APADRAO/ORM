using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ORM.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuAcesso",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    endereco = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuAcesso", x => x.id);
                    table.ForeignKey(
                        name: "FK_MenuAcesso_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RoleId",
                table: "Usuarios",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcesso_RoleId",
                table: "MenuAcesso",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Role_RoleId",
                table: "Usuarios",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Role_RoleId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "MenuAcesso");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RoleId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Usuarios");
        }
    }
}

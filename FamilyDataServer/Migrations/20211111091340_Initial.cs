using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyDataServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildPet");

            migrationBuilder.DropTable(
                name: "FamilyPet");

            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "Pets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyId",
                table: "Pets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ChildId",
                table: "Pets",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_FamilyId",
                table: "Pets",
                column: "FamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Children_ChildId",
                table: "Pets",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Families_FamilyId",
                table: "Pets",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Children_ChildId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Families_FamilyId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ChildId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_FamilyId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "Pets");

            migrationBuilder.CreateTable(
                name: "ChildPet",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "INTEGER", nullable: false),
                    PetsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildPet", x => new { x.ChildrenId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_ChildPet_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyPet",
                columns: table => new
                {
                    FamiliesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PetsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyPet", x => new { x.FamiliesId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_FamilyPet_Families_FamiliesId",
                        column: x => x.FamiliesId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildPet_PetsId",
                table: "ChildPet",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPet_PetsId",
                table: "FamilyPet",
                column: "PetsId");
        }
    }
}

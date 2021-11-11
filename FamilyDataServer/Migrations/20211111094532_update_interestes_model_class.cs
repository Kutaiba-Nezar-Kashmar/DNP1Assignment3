using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyDataServer.Migrations
{
    public partial class update_interestes_model_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildInterest");

            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "Interest",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interest_ChildId",
                table: "Interest",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_Children_ChildId",
                table: "Interest",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interest_Children_ChildId",
                table: "Interest");

            migrationBuilder.DropIndex(
                name: "IX_Interest_ChildId",
                table: "Interest");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Interest");

            migrationBuilder.CreateTable(
                name: "ChildInterest",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "INTEGER", nullable: false),
                    InterestsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildInterest", x => new { x.ChildrenId, x.InterestsId });
                    table.ForeignKey(
                        name: "FK_ChildInterest_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildInterest_Interest_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildInterest_InterestsId",
                table: "ChildInterest",
                column: "InterestsId");
        }
    }
}

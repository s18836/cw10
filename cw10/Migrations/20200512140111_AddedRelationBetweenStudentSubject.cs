using Microsoft.EntityFrameworkCore.Migrations;

namespace cw10.Migrations
{
    public partial class AddedRelationBetweenStudentSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdSubject",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndexNumber",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubcjetIdSubject",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_SubcjetIdSubject",
                table: "People",
                column: "SubcjetIdSubject");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Subjects_SubcjetIdSubject",
                table: "People",
                column: "SubcjetIdSubject",
                principalTable: "Subjects",
                principalColumn: "IdSubject",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Subjects_SubcjetIdSubject",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_SubcjetIdSubject",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "People");

            migrationBuilder.DropColumn(
                name: "IndexNumber",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SubcjetIdSubject",
                table: "People");
        }
    }
}

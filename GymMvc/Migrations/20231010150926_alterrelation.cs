using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMvc.Migrations
{
    /// <inheritdoc />
    public partial class alterrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sent",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Sent",
                table: "Notifications",
                column: "Sent");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Information_Sent",
                table: "Notifications",
                column: "Sent",
                principalTable: "Information",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Information_Sent",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_Sent",
                table: "Notifications");

            migrationBuilder.AlterColumn<int>(
                name: "Sent",
                table: "Notifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}

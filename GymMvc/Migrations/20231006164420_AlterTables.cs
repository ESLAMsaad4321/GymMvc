using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMvc.Migrations
{
    /// <inheritdoc />
    public partial class AlterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ScheduleWorkOuts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ScheduleWorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

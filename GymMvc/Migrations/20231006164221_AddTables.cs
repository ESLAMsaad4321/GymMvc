using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoacheId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkOuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleWorkOuts",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    WorkOutId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleWorkOuts", x => new { x.ScheduleId, x.WorkOutId });
                    table.ForeignKey(
                        name: "FK_ScheduleWorkOuts_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleWorkOuts_WorkOuts_WorkOutId",
                        column: x => x.WorkOutId,
                        principalTable: "WorkOuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WorkOuts",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "dumbbell-bench-press.jpg", "dumbbell bench press" },
                    { 2, "seated-chest-press.jpg", "seated chest press" },
                    { 3, "how-to-shoulder-press-mchine.jpg", "seated shoulder press machine" },
                    { 4, "tricep-pushdown.png", "tricep pushdown" },
                    { 5, "latpulldownimage.jpg", "lat pulldown" },
                    { 6, "barbell-row.png", "barbell bent over row" },
                    { 7, "chest-supported-row.jpg", "incline dumbbell row, or chest supported row" },
                    { 8, "seated-rear-delt-fly.png", "Face pulls" },
                    { 9, "bicep.jpg", "bicep curl" },
                    { 10, "squat-2x.jpg", "Squats" },
                    { 11, "leg-press.jpg", "leg press" },
                    { 12, "leg-curl.png", "Hamstring curls" },
                    { 13, "lunge-2x.jpg", "lunge" },
                    { 14, "calf-raises.jpg", "calf raises" },
                    { 15, "rear-delt-fly.jpg", "posterior deltoids" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleWorkOuts_WorkOutId",
                table: "ScheduleWorkOuts",
                column: "WorkOutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleWorkOuts");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "WorkOuts");
        }
    }
}

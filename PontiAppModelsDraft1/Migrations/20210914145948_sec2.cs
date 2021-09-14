using Microsoft.EntityFrameworkCore.Migrations;

namespace PontiAppModelsDraft1.Migrations
{
    public partial class sec2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Users_UserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHostEvent_Events_EventId",
                table: "UserHostEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHostEvent_Users_UserId",
                table: "UserHostEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHostEvent",
                table: "UserHostEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEvents",
                table: "UserEvents");

            migrationBuilder.RenameTable(
                name: "UserHostEvent",
                newName: "UserHostEvents");

            migrationBuilder.RenameTable(
                name: "UserEvents",
                newName: "UserGuestEvents");

            migrationBuilder.RenameIndex(
                name: "IX_UserHostEvent_UserId",
                table: "UserHostEvents",
                newName: "IX_UserHostEvents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEvents_UserId",
                table: "UserGuestEvents",
                newName: "IX_UserGuestEvents_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHostEvents",
                table: "UserHostEvents",
                columns: new[] { "EventId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGuestEvents",
                table: "UserGuestEvents",
                columns: new[] { "EventId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserGuestEvents_Events_EventId",
                table: "UserGuestEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGuestEvents_Users_UserId",
                table: "UserGuestEvents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHostEvents_Events_EventId",
                table: "UserHostEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHostEvents_Users_UserId",
                table: "UserHostEvents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGuestEvents_Events_EventId",
                table: "UserGuestEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGuestEvents_Users_UserId",
                table: "UserGuestEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHostEvents_Events_EventId",
                table: "UserHostEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHostEvents_Users_UserId",
                table: "UserHostEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHostEvents",
                table: "UserHostEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGuestEvents",
                table: "UserGuestEvents");

            migrationBuilder.RenameTable(
                name: "UserHostEvents",
                newName: "UserHostEvent");

            migrationBuilder.RenameTable(
                name: "UserGuestEvents",
                newName: "UserEvents");

            migrationBuilder.RenameIndex(
                name: "IX_UserHostEvents_UserId",
                table: "UserHostEvent",
                newName: "IX_UserHostEvent_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserGuestEvents_UserId",
                table: "UserEvents",
                newName: "IX_UserEvents_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHostEvent",
                table: "UserHostEvent",
                columns: new[] { "EventId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEvents",
                table: "UserEvents",
                columns: new[] { "EventId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Users_UserId",
                table: "UserEvents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHostEvent_Events_EventId",
                table: "UserHostEvent",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHostEvent_Users_UserId",
                table: "UserHostEvent",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

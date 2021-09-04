using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.API.Migrations
{
    public partial class AddTableVehicleTypeWithoutErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehcleTypes",
                table: "VehcleTypes");

            migrationBuilder.RenameTable(
                name: "VehcleTypes",
                newName: "VehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehcleTypes_Description",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleTypes",
                newName: "VehcleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Description",
                table: "VehcleTypes",
                newName: "IX_VehcleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehcleTypes",
                table: "VehcleTypes",
                column: "Id");
        }
    }
}

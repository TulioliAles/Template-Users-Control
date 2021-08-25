using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template_Users_Control.Data.Migrations
{
    public partial class InsertingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("67a4e611-061e-40b5-9670-5539e5695ab5"), "userdefault@template.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67a4e611-061e-40b5-9670-5539e5695ab5"));
        }
    }
}

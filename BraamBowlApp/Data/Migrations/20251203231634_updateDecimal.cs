using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BraamBowlApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Orders_Order_ID1",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Shops_Shop_ID",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_Shop_ID",
                table: "MenuItems");

            migrationBuilder.RenameColumn(
                name: "Order_ID1",
                table: "MenuItems",
                newName: "Shop_ID1");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_Order_ID1",
                table: "MenuItems",
                newName: "IX_MenuItems_Shop_ID1");

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Orders",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Delivery_Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_Number",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Payment_Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Shop_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Menu_Item_Name",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Shop_ID",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "MenuItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OTP",
                table: "Deliveries",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOTPVerified",
                table: "Deliveries",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "HasSeenWelcomeModal",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Order_ID",
                table: "MenuItems",
                column: "Order_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Orders_Order_ID",
                table: "MenuItems",
                column: "Order_ID",
                principalTable: "Orders",
                principalColumn: "Order_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Shops_Shop_ID1",
                table: "MenuItems",
                column: "Shop_ID1",
                principalTable: "Shops",
                principalColumn: "Shop_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Orders_Order_ID",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Shops_Shop_ID1",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_Order_ID",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Delivery_Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item_Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Order_Number",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Payment_Date",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Shop_Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Menu_Item_Name",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "HasSeenWelcomeModal",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Shop_ID1",
                table: "MenuItems",
                newName: "Order_ID1");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_Shop_ID1",
                table: "MenuItems",
                newName: "IX_MenuItems_Order_ID1");

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Shop_ID",
                table: "MenuItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OTP",
                table: "Deliveries",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOTPVerified",
                table: "Deliveries",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Shop_ID",
                table: "MenuItems",
                column: "Shop_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Orders_Order_ID1",
                table: "MenuItems",
                column: "Order_ID1",
                principalTable: "Orders",
                principalColumn: "Order_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Shops_Shop_ID",
                table: "MenuItems",
                column: "Shop_ID",
                principalTable: "Shops",
                principalColumn: "Shop_ID");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class actualizarID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_owner_OwnerId",
                table: "account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owner",
                table: "owner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "owner");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "account");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "owner",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "account",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_owner",
                table: "owner",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_account_owner_OwnerId",
                table: "account",
                column: "OwnerId",
                principalTable: "owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_owner_OwnerId",
                table: "account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owner",
                table: "owner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "owner");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "account");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "owner",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "account",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_owner",
                table: "owner",
                column: "OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_account_owner_OwnerId",
                table: "account",
                column: "OwnerId",
                principalTable: "owner",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

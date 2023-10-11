﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eassydentalmvc.Migrations
{
    public partial class AddDentistaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Dentista",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Telefone = table.Column<int>(type: "int", nullable: false),
                   Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   CRO = table.Column<int>(type: "int", nullable: false),
                   Nome_da_clinica= table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Endereço= table.Column<string>(type: "nvarchar(max)", nullable: false),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Cliente", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dentista");
        }
    }
}
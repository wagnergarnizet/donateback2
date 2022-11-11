﻿using Api.Backend.Domain.Models;
using Api.Backend.Enums;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.Mime.MediaTypeNames;

namespace Api.Backend.Migrations
{
    public partial class PopulatabeladeUsuarios : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO usuarios VALUES(1, 'usuarioUm', 'usuarioUm@teste.com', 123, 1, 1);");
            mb.Sql("INSERT INTO usuarios VALUES(2, 'usuarioDois', 'usuarioDois@teste.com', 123, 1, 2);");
            mb.Sql("INSERT INTO usuarios VALUES(3, 'usuarioTres', 'usuarioTres@teste.com', 123, 0, 1);");
            mb.Sql("INSERT INTO usuarios VALUES(4, 'usuarioQuatro', 'usuarioQuatro@teste.com', 123, 1, 3);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM usuarios");
        }
    }
}
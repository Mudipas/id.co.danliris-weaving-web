﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanLiris.Admin.Web.Migrations
{
    public partial class weavingversion112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weaving_SupplierDocuments",
                columns: table => new
                {
                    Identity = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 32, nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 32, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 32, nullable: true),
                    Code = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    CoreSupplierId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weaving_SupplierDocuments", x => x.Identity);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weaving_SupplierDocuments");
        }
    }
}

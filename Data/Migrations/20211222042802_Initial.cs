using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMKHACHHANGs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENKHACH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMKHACHHANGs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DMLOAIBAIVIETs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENLOAI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMLOAIBAIVIETs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DMLOAIDICHVUs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENDICHVU = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMLOAIDICHVUs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KETBANs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KETBANs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MESSAGEs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SUBJECT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MESSAGE_BODY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESSAGEs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MONTHETHAOs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SPORT_NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DISCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MONTHETHAOs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TAOGIAIs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENGIAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOLUONGGIAI = table.Column<int>(type: "int", nullable: false),
                    LOAIGIAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THOIGIAN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DIADIEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAOGIAIs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DMBAIVIETs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENBAI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMLOAIBAIVIETID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMBAIVIETs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DMBAIVIETs_DMLOAIBAIVIETs_DMLOAIBAIVIETID",
                        column: x => x.DMLOAIBAIVIETID,
                        principalTable: "DMLOAIBAIVIETs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANGDICHVUs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DMLOAIDICHVUID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DMKHACHHANGID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANGDICHVUs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KHACHHANGDICHVUs_DMKHACHHANGs_DMKHACHHANGID",
                        column: x => x.DMKHACHHANGID,
                        principalTable: "DMKHACHHANGs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KHACHHANGDICHVUs_DMLOAIDICHVUs_DMLOAIDICHVUID",
                        column: x => x.DMLOAIDICHVUID,
                        principalTable: "DMLOAIDICHVUs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NGUOIDUNGs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEX = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KETBANID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MESSAGEID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGUOIDUNGs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NGUOIDUNGs_KETBANs_KETBANID",
                        column: x => x.KETBANID,
                        principalTable: "KETBANs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NGUOIDUNGs_MESSAGEs_MESSAGEID",
                        column: x => x.MESSAGEID,
                        principalTable: "MESSAGEs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "THETHAONGUOIDUNGs",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NGUOIDUNGID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MONTHETHAOID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PRESTIGE_POINTS = table.Column<int>(type: "int", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THETHAONGUOIDUNGs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_THETHAONGUOIDUNGs_MONTHETHAOs_MONTHETHAOID",
                        column: x => x.MONTHETHAOID,
                        principalTable: "MONTHETHAOs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THETHAONGUOIDUNGs_NGUOIDUNGs_NGUOIDUNGID",
                        column: x => x.NGUOIDUNGID,
                        principalTable: "NGUOIDUNGs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DMBAIVIETs_DMLOAIBAIVIETID",
                table: "DMBAIVIETs",
                column: "DMLOAIBAIVIETID");

            migrationBuilder.CreateIndex(
                name: "IX_KHACHHANGDICHVUs_DMKHACHHANGID",
                table: "KHACHHANGDICHVUs",
                column: "DMKHACHHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_KHACHHANGDICHVUs_DMLOAIDICHVUID",
                table: "KHACHHANGDICHVUs",
                column: "DMLOAIDICHVUID");

            migrationBuilder.CreateIndex(
                name: "IX_NGUOIDUNGs_KETBANID",
                table: "NGUOIDUNGs",
                column: "KETBANID");

            migrationBuilder.CreateIndex(
                name: "IX_NGUOIDUNGs_MESSAGEID",
                table: "NGUOIDUNGs",
                column: "MESSAGEID");

            migrationBuilder.CreateIndex(
                name: "IX_THETHAONGUOIDUNGs_MONTHETHAOID",
                table: "THETHAONGUOIDUNGs",
                column: "MONTHETHAOID");

            migrationBuilder.CreateIndex(
                name: "IX_THETHAONGUOIDUNGs_NGUOIDUNGID",
                table: "THETHAONGUOIDUNGs",
                column: "NGUOIDUNGID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMBAIVIETs");

            migrationBuilder.DropTable(
                name: "KHACHHANGDICHVUs");

            migrationBuilder.DropTable(
                name: "TAOGIAIs");

            migrationBuilder.DropTable(
                name: "THETHAONGUOIDUNGs");

            migrationBuilder.DropTable(
                name: "DMLOAIBAIVIETs");

            migrationBuilder.DropTable(
                name: "DMKHACHHANGs");

            migrationBuilder.DropTable(
                name: "DMLOAIDICHVUs");

            migrationBuilder.DropTable(
                name: "MONTHETHAOs");

            migrationBuilder.DropTable(
                name: "NGUOIDUNGs");

            migrationBuilder.DropTable(
                name: "KETBANs");

            migrationBuilder.DropTable(
                name: "MESSAGEs");
        }
    }
}

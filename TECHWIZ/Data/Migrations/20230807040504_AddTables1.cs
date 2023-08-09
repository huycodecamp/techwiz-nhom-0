using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TECHWIZ.Data.Migrations
{
    public partial class AddTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCategories_AspNetUsers_CreatedUser",
                        column: x => x.CreatedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalCategories_MedicalCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MedicalCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_AspNetUsers_CreatedUser",
                        column: x => x.CreatedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prescriptions_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalDetails_AspNetUsers_CreatedUser",
                        column: x => x.CreatedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalDetails_MedicalCategories_MedicalCategoryId",
                        column: x => x.MedicalCategoryId,
                        principalTable: "MedicalCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    MedicalDetailId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionDetails_AspNetUsers_CreatedUser",
                        column: x => x.CreatedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrescriptionDetails_MedicalDetails_MedicalDetailId",
                        column: x => x.MedicalDetailId,
                        principalTable: "MedicalDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrescriptionDetails_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCategories_CreatedUser",
                table: "MedicalCategories",
                column: "CreatedUser");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCategories_ParentId",
                table: "MedicalCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalDetails_CreatedUser",
                table: "MedicalDetails",
                column: "CreatedUser");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalDetails_MedicalCategoryId",
                table: "MedicalDetails",
                column: "MedicalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetails_CreatedUser",
                table: "PrescriptionDetails",
                column: "CreatedUser");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetails_MedicalDetailId",
                table: "PrescriptionDetails",
                column: "MedicalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetails_PrescriptionId",
                table: "PrescriptionDetails",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_CreatedUser",
                table: "Prescriptions",
                column: "CreatedUser");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionDetails");

            migrationBuilder.DropTable(
                name: "MedicalDetails");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "MedicalCategories");
        }
    }
}

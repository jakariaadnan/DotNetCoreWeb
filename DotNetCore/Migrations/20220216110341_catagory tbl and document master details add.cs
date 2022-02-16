using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore.Migrations
{
    public partial class catagorytblanddocumentmasterdetailsadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Divisions_divisionId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_AspNetUsers_ApplicationUserId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_BCSBatches_bCSBatchId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_SpecialBranchUnits_branchId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_Departments_departmentId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_Designations_designationsId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_EmployeeTypes_employeeTypeId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_Ranks_rankId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_Religions_religionId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfos_Sections_sectionId",
                table: "EmployeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_SpecialBranchUnits_specialBranchUnitId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialBranchUnits_Districts_districtsId",
                table: "SpecialBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecialBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                table: "SpecialBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_SubBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                table: "SubBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogs_EmployeeInfos_employeeId",
                table: "UserLogs");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogs",
                table: "UserLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubBranchUnits",
                table: "SubBranchUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusInfos",
                table: "StatusInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialBranchUnits",
                table: "SpecialBranchUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Religions",
                table: "Religions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeInfos",
                table: "EmployeeInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divisions",
                table: "Divisions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Districts",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BCSBatches",
                table: "BCSBatches");

            migrationBuilder.RenameTable(
                name: "UserLogs",
                newName: "userLogs");

            migrationBuilder.RenameTable(
                name: "SubBranchUnits",
                newName: "subBranchUnits");

            migrationBuilder.RenameTable(
                name: "StatusInfos",
                newName: "statusInfos");

            migrationBuilder.RenameTable(
                name: "SpecialBranchUnits",
                newName: "specialBranchUnits");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "sections");

            migrationBuilder.RenameTable(
                name: "Religions",
                newName: "religions");

            migrationBuilder.RenameTable(
                name: "Ranks",
                newName: "ranks");

            migrationBuilder.RenameTable(
                name: "EmployeeTypes",
                newName: "employeeTypes");

            migrationBuilder.RenameTable(
                name: "EmployeeInfos",
                newName: "employeeInfos");

            migrationBuilder.RenameTable(
                name: "Divisions",
                newName: "divisions");

            migrationBuilder.RenameTable(
                name: "Districts",
                newName: "districts");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "designations");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "BCSBatches",
                newName: "bCSBatches");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogs_employeeId",
                table: "userLogs",
                newName: "IX_userLogs_employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubBranchUnits_specialBranchUnitId",
                table: "subBranchUnits",
                newName: "IX_subBranchUnits_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBranchUnits_specialBranchUnitId",
                table: "specialBranchUnits",
                newName: "IX_specialBranchUnits_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SpecialBranchUnits_districtsId",
                table: "specialBranchUnits",
                newName: "IX_specialBranchUnits_districtsId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_specialBranchUnitId",
                table: "sections",
                newName: "IX_sections_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_sectionId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_sectionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_religionId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_religionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_rankId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_rankId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_employeeTypeId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_employeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_designationsId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_designationsId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_departmentId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_branchId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_branchId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_bCSBatchId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_bCSBatchId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeInfos_ApplicationUserId",
                table: "employeeInfos",
                newName: "IX_employeeInfos_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_divisionId",
                table: "districts",
                newName: "IX_districts_divisionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userLogs",
                table: "userLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subBranchUnits",
                table: "subBranchUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_statusInfos",
                table: "statusInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_specialBranchUnits",
                table: "specialBranchUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sections",
                table: "sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_religions",
                table: "religions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ranks",
                table: "ranks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeeTypes",
                table: "employeeTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeeInfos",
                table: "employeeInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_divisions",
                table: "divisions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_districts",
                table: "districts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_designations",
                table: "designations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bCSBatches",
                table: "bCSBatches",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "documentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    categoryName = table.Column<string>(nullable: true),
                    categoryCode = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "documentMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    employeeId = table.Column<int>(nullable: true),
                    documentNumber = table.Column<string>(nullable: true),
                    subject = table.Column<string>(nullable: true),
                    departmentId = table.Column<int>(nullable: true),
                    keywords = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: true),
                    documentCategoryId = table.Column<int>(nullable: true),
                    documentName = table.Column<string>(nullable: true),
                    documentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_documentMaster_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_documentMaster_documentCategories_documentCategoryId",
                        column: x => x.documentCategoryId,
                        principalTable: "documentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_documentMaster_employeeInfos_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employeeInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "documentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    documentMasterId = table.Column<int>(nullable: true),
                    fileUrl = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_documentDetails_documentMaster_documentMasterId",
                        column: x => x.documentMasterId,
                        principalTable: "documentMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_documentDetails_documentMasterId",
                table: "documentDetails",
                column: "documentMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_documentMaster_departmentId",
                table: "documentMaster",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_documentMaster_documentCategoryId",
                table: "documentMaster",
                column: "documentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_documentMaster_employeeId",
                table: "documentMaster",
                column: "employeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_districts_divisions_divisionId",
                table: "districts",
                column: "divisionId",
                principalTable: "divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_AspNetUsers_ApplicationUserId",
                table: "employeeInfos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_bCSBatches_bCSBatchId",
                table: "employeeInfos",
                column: "bCSBatchId",
                principalTable: "bCSBatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_specialBranchUnits_branchId",
                table: "employeeInfos",
                column: "branchId",
                principalTable: "specialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_departments_departmentId",
                table: "employeeInfos",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_designations_designationsId",
                table: "employeeInfos",
                column: "designationsId",
                principalTable: "designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_employeeTypes_employeeTypeId",
                table: "employeeInfos",
                column: "employeeTypeId",
                principalTable: "employeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_ranks_rankId",
                table: "employeeInfos",
                column: "rankId",
                principalTable: "ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_religions_religionId",
                table: "employeeInfos",
                column: "religionId",
                principalTable: "religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeInfos_sections_sectionId",
                table: "employeeInfos",
                column: "sectionId",
                principalTable: "sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sections_specialBranchUnits_specialBranchUnitId",
                table: "sections",
                column: "specialBranchUnitId",
                principalTable: "specialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_specialBranchUnits_districts_districtsId",
                table: "specialBranchUnits",
                column: "districtsId",
                principalTable: "districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_specialBranchUnits_specialBranchUnits_specialBranchUnitId",
                table: "specialBranchUnits",
                column: "specialBranchUnitId",
                principalTable: "specialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_subBranchUnits_specialBranchUnits_specialBranchUnitId",
                table: "subBranchUnits",
                column: "specialBranchUnitId",
                principalTable: "specialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userLogs_employeeInfos_employeeId",
                table: "userLogs",
                column: "employeeId",
                principalTable: "employeeInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_districts_divisions_divisionId",
                table: "districts");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_AspNetUsers_ApplicationUserId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_bCSBatches_bCSBatchId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_specialBranchUnits_branchId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_departments_departmentId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_designations_designationsId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_employeeTypes_employeeTypeId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_ranks_rankId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_religions_religionId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_employeeInfos_sections_sectionId",
                table: "employeeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_sections_specialBranchUnits_specialBranchUnitId",
                table: "sections");

            migrationBuilder.DropForeignKey(
                name: "FK_specialBranchUnits_districts_districtsId",
                table: "specialBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_specialBranchUnits_specialBranchUnits_specialBranchUnitId",
                table: "specialBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_subBranchUnits_specialBranchUnits_specialBranchUnitId",
                table: "subBranchUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_userLogs_employeeInfos_employeeId",
                table: "userLogs");

            migrationBuilder.DropTable(
                name: "documentDetails");

            migrationBuilder.DropTable(
                name: "documentMaster");

            migrationBuilder.DropTable(
                name: "documentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userLogs",
                table: "userLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subBranchUnits",
                table: "subBranchUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statusInfos",
                table: "statusInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_specialBranchUnits",
                table: "specialBranchUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sections",
                table: "sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_religions",
                table: "religions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ranks",
                table: "ranks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employeeTypes",
                table: "employeeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employeeInfos",
                table: "employeeInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_divisions",
                table: "divisions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_districts",
                table: "districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_designations",
                table: "designations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bCSBatches",
                table: "bCSBatches");

            migrationBuilder.RenameTable(
                name: "userLogs",
                newName: "UserLogs");

            migrationBuilder.RenameTable(
                name: "subBranchUnits",
                newName: "SubBranchUnits");

            migrationBuilder.RenameTable(
                name: "statusInfos",
                newName: "StatusInfos");

            migrationBuilder.RenameTable(
                name: "specialBranchUnits",
                newName: "SpecialBranchUnits");

            migrationBuilder.RenameTable(
                name: "sections",
                newName: "Sections");

            migrationBuilder.RenameTable(
                name: "religions",
                newName: "Religions");

            migrationBuilder.RenameTable(
                name: "ranks",
                newName: "Ranks");

            migrationBuilder.RenameTable(
                name: "employeeTypes",
                newName: "EmployeeTypes");

            migrationBuilder.RenameTable(
                name: "employeeInfos",
                newName: "EmployeeInfos");

            migrationBuilder.RenameTable(
                name: "divisions",
                newName: "Divisions");

            migrationBuilder.RenameTable(
                name: "districts",
                newName: "Districts");

            migrationBuilder.RenameTable(
                name: "designations",
                newName: "Designations");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "bCSBatches",
                newName: "BCSBatches");

            migrationBuilder.RenameIndex(
                name: "IX_userLogs_employeeId",
                table: "UserLogs",
                newName: "IX_UserLogs_employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_subBranchUnits_specialBranchUnitId",
                table: "SubBranchUnits",
                newName: "IX_SubBranchUnits_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_specialBranchUnits_specialBranchUnitId",
                table: "SpecialBranchUnits",
                newName: "IX_SpecialBranchUnits_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_specialBranchUnits_districtsId",
                table: "SpecialBranchUnits",
                newName: "IX_SpecialBranchUnits_districtsId");

            migrationBuilder.RenameIndex(
                name: "IX_sections_specialBranchUnitId",
                table: "Sections",
                newName: "IX_Sections_specialBranchUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_sectionId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_sectionId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_religionId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_religionId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_rankId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_rankId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_employeeTypeId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_employeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_designationsId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_designationsId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_departmentId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_branchId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_branchId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_bCSBatchId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_bCSBatchId");

            migrationBuilder.RenameIndex(
                name: "IX_employeeInfos_ApplicationUserId",
                table: "EmployeeInfos",
                newName: "IX_EmployeeInfos_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_districts_divisionId",
                table: "Districts",
                newName: "IX_Districts_divisionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogs",
                table: "UserLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubBranchUnits",
                table: "SubBranchUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusInfos",
                table: "StatusInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialBranchUnits",
                table: "SpecialBranchUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Religions",
                table: "Religions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeInfos",
                table: "EmployeeInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divisions",
                table: "Divisions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Districts",
                table: "Districts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BCSBatches",
                table: "BCSBatches",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    createdAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    date = table.Column<DateTime>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    documentName = table.Column<string>(nullable: true),
                    documentType = table.Column<string>(nullable: true),
                    employeeId = table.Column<int>(nullable: true),
                    fileUrl = table.Column<string>(nullable: true),
                    isDelete = table.Column<int>(nullable: true),
                    remarks = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_EmployeeInfos_employeeId",
                        column: x => x.employeeId,
                        principalTable: "EmployeeInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_employeeId",
                table: "EmployeeDocuments",
                column: "employeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Divisions_divisionId",
                table: "Districts",
                column: "divisionId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_AspNetUsers_ApplicationUserId",
                table: "EmployeeInfos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_BCSBatches_bCSBatchId",
                table: "EmployeeInfos",
                column: "bCSBatchId",
                principalTable: "BCSBatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_SpecialBranchUnits_branchId",
                table: "EmployeeInfos",
                column: "branchId",
                principalTable: "SpecialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_Departments_departmentId",
                table: "EmployeeInfos",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_Designations_designationsId",
                table: "EmployeeInfos",
                column: "designationsId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_EmployeeTypes_employeeTypeId",
                table: "EmployeeInfos",
                column: "employeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_Ranks_rankId",
                table: "EmployeeInfos",
                column: "rankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_Religions_religionId",
                table: "EmployeeInfos",
                column: "religionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfos_Sections_sectionId",
                table: "EmployeeInfos",
                column: "sectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_SpecialBranchUnits_specialBranchUnitId",
                table: "Sections",
                column: "specialBranchUnitId",
                principalTable: "SpecialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialBranchUnits_Districts_districtsId",
                table: "SpecialBranchUnits",
                column: "districtsId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                table: "SpecialBranchUnits",
                column: "specialBranchUnitId",
                principalTable: "SpecialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                table: "SubBranchUnits",
                column: "specialBranchUnitId",
                principalTable: "SpecialBranchUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogs_EmployeeInfos_employeeId",
                table: "UserLogs",
                column: "employeeId",
                principalTable: "EmployeeInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

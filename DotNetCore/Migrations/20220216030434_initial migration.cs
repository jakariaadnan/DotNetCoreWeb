using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    isActive = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 120, nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    updatedBy = table.Column<string>(maxLength: 120, nullable: true),
                    bpNo = table.Column<string>(maxLength: 20, nullable: true),
                    otpCode = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BCSBatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    batchName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    batchNameBn = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCSBatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    deptCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    deptName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    deptNameBn = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    startDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    designationCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    designationName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    designationNameBN = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    divisionCode = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    divisionName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    divisionNameBn = table.Column<string>(nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    isActive = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    latitude = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    longitude = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    empType = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    empTypeBn = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    rankCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    rankName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    rankNameBN = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    name = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    nameBn = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    statusName = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    statusNameBn = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    divisionId = table.Column<int>(nullable: false),
                    districtCode = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    districtName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    districtNameBn = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    shortName = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    isActive = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    latitude = table.Column<string>(type: "NVARCHAR(120)", nullable: true),
                    longitude = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialBranchUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    branchUnitName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    branchUnitNameBN = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    branchCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    isParent = table.Column<int>(nullable: true),
                    specialBranchUnitId = table.Column<int>(nullable: true),
                    districtsId = table.Column<int>(nullable: true),
                    shortOrder = table.Column<int>(nullable: true),
                    isdefault = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialBranchUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialBranchUnits_Districts_districtsId",
                        column: x => x.districtsId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                        column: x => x.specialBranchUnitId,
                        principalTable: "SpecialBranchUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    NameBN = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true),
                    specialBranchUnitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_SpecialBranchUnits_specialBranchUnitId",
                        column: x => x.specialBranchUnitId,
                        principalTable: "SpecialBranchUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubBranchUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    specialBranchUnitId = table.Column<int>(nullable: true),
                    branchUnitName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    branchUnitNameBn = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubBranchUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubBranchUnits_SpecialBranchUnits_specialBranchUnitId",
                        column: x => x.specialBranchUnitId,
                        principalTable: "SpecialBranchUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDelete = table.Column<int>(nullable: true),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 250, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 250, nullable: true),
                    employeeCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    nationalID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    birthIdentificationNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    govtID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    gpfNomineeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    gpfAcNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    nameEnglish = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    nameBangla = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    motherNameEnglish = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    motherNameBangla = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    fatherNameEnglish = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    fatherNameBangla = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    disability = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    servicePeriod = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    salaryAccountNo = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    bankAccount = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    otherBankAccountNo = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    passportNo = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    facebookId = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    linkdInId = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    tribal = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    identificationSign = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    height = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    joiningDatePresentWorkstation = table.Column<DateTime>(nullable: true),
                    joiningDateGovtService = table.Column<DateTime>(nullable: true),
                    dateofregularity = table.Column<DateTime>(nullable: true),
                    dateOfPermanent = table.Column<DateTime>(nullable: true),
                    LPRDate = table.Column<DateTime>(nullable: true),
                    PRLStartDate = table.Column<DateTime>(nullable: true),
                    PRLEndDate = table.Column<DateTime>(nullable: true),
                    promotionDate = table.Column<DateTime>(nullable: true),
                    gender = table.Column<string>(maxLength: 10, nullable: true),
                    birthPlace = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    maritalStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    religionId = table.Column<int>(nullable: true),
                    employeeTypeId = table.Column<int>(nullable: true),
                    activityStatus = table.Column<int>(nullable: true),
                    departmentId = table.Column<int>(nullable: true),
                    batch = table.Column<string>(nullable: true),
                    bloodGroup = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    freedomFighter = table.Column<bool>(nullable: false),
                    freedomFighterNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    telephoneOffice = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    telephoneResidence = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    pabx = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    emailAddress = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    emailAddressPersonal = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    mobileNumberOffice = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    mobileNumberPersonal = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    specialSkill = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    seniorityNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    designation = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    skypeId = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    post = table.Column<int>(nullable: true),
                    designationCheck = table.Column<int>(nullable: false),
                    joiningDesignation = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    natureOfRequitment = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    homeDistrict = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    drivingLicense = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    rationId = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    branchId = table.Column<int>(nullable: true),
                    rankId = table.Column<int>(nullable: true),
                    designationsId = table.Column<int>(nullable: true),
                    sectionId = table.Column<int>(nullable: true),
                    bCSBatchId = table.Column<int>(nullable: true),
                    bcsPosition = table.Column<int>(nullable: true),
                    departmentalPromotionYear = table.Column<int>(nullable: true),
                    skill = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    extraActivity = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    sectionName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    extraSkill = table.Column<string>(nullable: true),
                    extraActivitys = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    isApproved = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_BCSBatches_bCSBatchId",
                        column: x => x.bCSBatchId,
                        principalTable: "BCSBatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_SpecialBranchUnits_branchId",
                        column: x => x.branchId,
                        principalTable: "SpecialBranchUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Designations_designationsId",
                        column: x => x.designationsId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_EmployeeTypes_employeeTypeId",
                        column: x => x.employeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Ranks_rankId",
                        column: x => x.rankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Religions_religionId",
                        column: x => x.religionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Sections_sectionId",
                        column: x => x.sectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogs",
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
                    date = table.Column<DateTime>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    remarks = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogs_EmployeeInfos_employeeId",
                        column: x => x.employeeId,
                        principalTable: "EmployeeInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_divisionId",
                table: "Districts",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_ApplicationUserId",
                table: "EmployeeInfos",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_bCSBatchId",
                table: "EmployeeInfos",
                column: "bCSBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_branchId",
                table: "EmployeeInfos",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_departmentId",
                table: "EmployeeInfos",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_designationsId",
                table: "EmployeeInfos",
                column: "designationsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_employeeTypeId",
                table: "EmployeeInfos",
                column: "employeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_rankId",
                table: "EmployeeInfos",
                column: "rankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_religionId",
                table: "EmployeeInfos",
                column: "religionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_sectionId",
                table: "EmployeeInfos",
                column: "sectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_specialBranchUnitId",
                table: "Sections",
                column: "specialBranchUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialBranchUnits_districtsId",
                table: "SpecialBranchUnits",
                column: "districtsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialBranchUnits_specialBranchUnitId",
                table: "SpecialBranchUnits",
                column: "specialBranchUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SubBranchUnits_specialBranchUnitId",
                table: "SubBranchUnits",
                column: "specialBranchUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_employeeId",
                table: "UserLogs",
                column: "employeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "StatusInfos");

            migrationBuilder.DropTable(
                name: "SubBranchUnits");

            migrationBuilder.DropTable(
                name: "UserLogs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EmployeeInfos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BCSBatches");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "SpecialBranchUnits");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Divisions");
        }
    }
}

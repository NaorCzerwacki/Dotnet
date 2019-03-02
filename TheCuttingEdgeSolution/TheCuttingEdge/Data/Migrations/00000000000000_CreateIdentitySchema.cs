using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCuttingEdge.Data.Migrations
{
    public partial class CreateIdentitySchema : Migration
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
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
                name: "Recipeslist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    UploadDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false),
                    Uploader = table.Column<string>(maxLength: 256, nullable: false),
                    UploaderID = table.Column<int>(nullable: false),

                    Ingredient1 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient2 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient3 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient4 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient5 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient6 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient7 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient8 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient9 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient10 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient11 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient12 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient13 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient14 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient15 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient16 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient17 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient18 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient19 = table.Column<string>(maxLength: 256, nullable: true),
                    Ingredient20 = table.Column<string>(maxLength: 256, nullable: true),

                    StepNumber1 = table.Column<int>(nullable: true),
                        Step1Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step1Timer = table.Column<bool>(nullable: false),
                        Step1TimerHour = table.Column<int>(nullable: false),
                        Step1TimerMinute = table.Column<int>(nullable: false),
                        Step1TimerSecond = table.Column<int>(nullable: false),
                    StepNumber2 = table.Column<int>(nullable: true),
                        Step2Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step2Timer = table.Column<bool>(nullable: false),
                        Step2TimerHour = table.Column<int>(nullable: false),
                        Step2TimerMinute = table.Column<int>(nullable: false),
                        Step2TimerSecond = table.Column<int>(nullable: false),
                    SteNumber3 = table.Column<int>(nullable: true),
                        Step3Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step3Timer = table.Column<bool>(nullable: false),
                        Step3TimerHour = table.Column<int>(nullable: false),
                        Step3TimerMinute = table.Column<int>(nullable: false),
                        Step3TimerSecond = table.Column<int>(nullable: false),
                    StepNumber4 = table.Column<int>(nullable: true),
                        Step4Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step4Timer = table.Column<bool>(nullable: false),
                        Step4TimerHour = table.Column<int>(nullable: false),
                        Step4TimerMinute = table.Column<int>(nullable: false),
                        Step4TimerSecond = table.Column<int>(nullable: false),
                    StepNumber5 = table.Column<int>(nullable: true),
                        Step5Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step5Timer = table.Column<bool>(nullable: false),
                        Step5TimerHour = table.Column<int>(nullable: false),
                        Step5TimerMinute = table.Column<int>(nullable: false),
                        Step5TimerSecond = table.Column<int>(nullable: false),
                    StepNumber6 = table.Column<int>(nullable: true),
                        Step6Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step6Timer = table.Column<bool>(nullable: false),
                        Step6TimerHour = table.Column<int>(nullable: false),
                        Step6TimerMinute = table.Column<int>(nullable: false),
                        Step6TimerSecond = table.Column<int>(nullable: false),
                    StepNumber7 = table.Column<int>(nullable: true),
                        Step7Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step7Timer = table.Column<bool>(nullable: false),
                        Step7TimerHour = table.Column<int>(nullable: false),
                        Step7TimerMinute = table.Column<int>(nullable: false),
                        Step7TimerSecond = table.Column<int>(nullable: false),
                    StepNumber8 = table.Column<int>(nullable: true),
                        Step8Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step8Timer = table.Column<bool>(nullable: false),
                        Step8TimerHour = table.Column<int>(nullable: false),
                        Step8TimerMinute = table.Column<int>(nullable: false),
                        Step8TimerSecond = table.Column<int>(nullable: false),
                    StepNumber9 = table.Column<int>(nullable: true),
                        Step9Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step9Timer = table.Column<bool>(nullable: false),
                        Step9TimerHour = table.Column<int>(nullable: false),
                        Step9TimerMinute = table.Column<int>(nullable: false),
                        Step9TimerSecond = table.Column<int>(nullable: false),
                    StepNumber10 = table.Column<int>(nullable: true),
                        Step10Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step10Timer = table.Column<bool>(nullable: false),
                        Step10TimerHour = table.Column<int>(nullable: false),
                        Step10TimerMinute = table.Column<int>(nullable: false),
                        Step10TimerSecond = table.Column<int>(nullable: false),
                    StepNumber11 = table.Column<int>(nullable: true),
                        Step11Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step11Timer = table.Column<bool>(nullable: false),
                        Step11TimerHour = table.Column<int>(nullable: false),
                        Step11TimerMinute = table.Column<int>(nullable: false),
                        Step11TimerSecond = table.Column<int>(nullable: false),
                    StepNumber12 = table.Column<int>(nullable: true),
                        Step12Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step12Timer = table.Column<bool>(nullable: false),
                        Step12TimerHour = table.Column<int>(nullable: false),
                        Step12TimerMinute = table.Column<int>(nullable: false),
                        Step12TimerSecond = table.Column<int>(nullable: false),
                    StepNumber13 = table.Column<int>(nullable: true),
                        Step13Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step13Timer = table.Column<bool>(nullable: false),
                        Step13TimerHour = table.Column<int>(nullable: false),
                        Step13TimerMinute = table.Column<int>(nullable: false),
                        Step13TimerSecond = table.Column<int>(nullable: false),
                    StepNumber14 = table.Column<int>(nullable: true),
                        Step14Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step14Timer = table.Column<bool>(nullable: false),
                        Step14TimerHour = table.Column<int>(nullable: false),
                        Step14TimerMinute = table.Column<int>(nullable: false),
                        Step14TimerSecond = table.Column<int>(nullable: false),
                    StepNumber15 = table.Column<int>(nullable: true),
                        Step15Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step15Timer = table.Column<bool>(nullable: false),
                        Step15TimerHour = table.Column<int>(nullable: false),
                        Step15TimerMinute = table.Column<int>(nullable: false),
                        Step15TimerSecond = table.Column<int>(nullable: false),
                    StepNumber16 = table.Column<int>(nullable: true),
                        Step16Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step16Timer = table.Column<bool>(nullable: false),
                        Step16TimerHour = table.Column<int>(nullable: false),
                        Step16TimerMinute = table.Column<int>(nullable: false),
                        Step16TimerSecond = table.Column<int>(nullable: false),
                    StepNumber17 = table.Column<int>(nullable: true),
                        Step17Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step17Timer = table.Column<bool>(nullable: false),
                        Step17TimerHour = table.Column<int>(nullable: false),
                        Step17TimerMinute = table.Column<int>(nullable: false),
                        Step17TimerSecond = table.Column<int>(nullable: false),
                    StepNumber18 = table.Column<string>(maxLength: 256, nullable: true),
                        Step18Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step18Timer = table.Column<bool>(nullable: false),
                        Step18TimerHour = table.Column<int>(nullable: false),
                        Step18TimerMinute = table.Column<int>(nullable: false),
                        Step18TimerSecond = table.Column<int>(nullable: false),
                    StepNumber19 = table.Column<int>(nullable: true),
                        Step19Description = table.Column<string>(maxLength: 256, nullable: true),
                        tep19Timer = table.Column<bool>(nullable: false),
                        Step19TimerHour = table.Column<int>(nullable: false),
                        Step19TimerMinute = table.Column<int>(nullable: false),
                        Step19TimerSecond = table.Column<int>(nullable: false),
                    StepNumber20 = table.Column<int>(nullable: true),
                        Step20Description = table.Column<string>(maxLength: 256, nullable: true),
                        Step20Timer = table.Column<bool>(nullable: false),
                        Step20TimerHour = table.Column<int>(nullable: false),
                        Step20TimerMinute = table.Column<int>(nullable: false),
                        Step20TimerSecond = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipeslist", x => x.Id);
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Recipeslist");
        }
    }
}

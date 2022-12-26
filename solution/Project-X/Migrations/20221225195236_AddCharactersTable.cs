using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjectX.Migrations
{
    public partial class AddCharactersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Father",
                columns: table => new
                {
                    FatherId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    RussianName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Father", x => x.FatherId);
                });

            migrationBuilder.CreateTable(
                name: "Mother",
                columns: table => new
                {
                    MotherId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    RussianName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mother", x => x.MotherId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Finance_Bank = table.Column<int>(nullable: true),
                    Finance_Cash = table.Column<int>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    FatherId = table.Column<int>(nullable: true),
                    MotherId = table.Column<int>(nullable: true),
                    Appearance = table.Column<float>(nullable: false),
                    ColorSkin = table.Column<float>(nullable: false),
                    Forehead = table.Column<float>(nullable: false),
                    Eyes = table.Column<float>(nullable: false),
                    Nose = table.Column<float>(nullable: false),
                    NoseProfile = table.Column<float>(nullable: false),
                    NoseTip = table.Column<float>(nullable: false),
                    Cheekbones = table.Column<float>(nullable: false),
                    Cheeks = table.Column<float>(nullable: false),
                    Lips = table.Column<float>(nullable: false),
                    Jaw = table.Column<float>(nullable: false),
                    ChinProfile = table.Column<float>(nullable: false),
                    ChinShape = table.Column<float>(nullable: false),
                    Hairstyles = table.Column<float>(nullable: false),
                    Brows = table.Column<float>(nullable: false),
                    SkinDefects = table.Column<float>(nullable: false),
                    SkinAging = table.Column<float>(nullable: false),
                    SkinType = table.Column<float>(nullable: false),
                    MolesAndFreckles = table.Column<float>(nullable: false),
                    SkinDamage = table.Column<float>(nullable: false),
                    EyeColor = table.Column<float>(nullable: false),
                    Makeup = table.Column<float>(nullable: false),
                    Blush = table.Column<float>(nullable: false),
                    Pomade = table.Column<float>(nullable: false),
                    ClothingStyle = table.Column<float>(nullable: false),
                    Costume = table.Column<float>(nullable: false),
                    Headress = table.Column<float>(nullable: false),
                    Glasses = table.Column<float>(nullable: false),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Father_FatherId",
                        column: x => x.FatherId,
                        principalTable: "Father",
                        principalColumn: "FatherId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Mother_MotherId",
                        column: x => x.MotherId,
                        principalTable: "Mother",
                        principalColumn: "MotherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AccountId",
                table: "Characters",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_FatherId",
                table: "Characters",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_MotherId",
                table: "Characters",
                column: "MotherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Father");

            migrationBuilder.DropTable(
                name: "Mother");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerDetailSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    CUST_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CUST_FIRST_NM = table.Column<string>(type: "varchar(50)", nullable: false),
                    CUST_MID_NM = table.Column<string>(type: "varchar(50)", nullable: false),
                    CUST_LAST_NM = table.Column<string>(type: "varchar(50)", nullable: false),
                    CUST_ADDRESS = table.Column<string>(type: "varchar(200)", nullable: false),
                    CUST_MOBILE_NO = table.Column<string>(type: "varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.CUST_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDetails");
        }
    }
}

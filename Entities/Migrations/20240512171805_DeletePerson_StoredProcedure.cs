using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    public partial class DeletePerson_StoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sp_DeleteAPerson = @"
                CREATE PROCEDURE [dbo].[DeleteAPerson] (@PersonID uniqueidentifier)
                AS BEGIN
                DELETE FROM [dbo].[Persons] WHERE PersonID = @PersonID
                END
                ";
            migrationBuilder.Sql(sp_DeleteAPerson);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sp_DeleteAPerson = @"DROP PROCEDURE [dbo].[DeleteAPerson]";
            migrationBuilder.Sql(sp_DeleteAPerson);
        }
    }
}

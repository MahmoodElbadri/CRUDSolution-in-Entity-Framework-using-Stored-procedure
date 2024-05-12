using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    public partial class UpdatePerson_StoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sp_UpdateAPerson = @"
                CREATE PROCEDURE [dbo].[UpdateAPerson] (
                    @PersonID uniqueidentifier,
                    @PersonName nvarchar(40),
                    @Email nvarchar(40),
                    @DateOfBirth datetime,
                    @Gender varchar(10),
                    @CountryID uniqueidentifier,
                    @Address varchar(200),
                    @ReceiveNewsLetters bit
                )
                AS 
                BEGIN
                    UPDATE [dbo].[Persons]
                    SET PersonName = @PersonName, 
                        Email = @Email, 
                        DateOfBirth = @DateOfBirth, 
                        Gender = @Gender, 
                        CountryID = @CountryID, 
                        Address = @Address, 
                        ReceiveNewsLetters = @ReceiveNewsLetters
                    WHERE PersonID = @PersonID
                END
";
            migrationBuilder.Sql(sp_UpdateAPerson);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sp_UpdateAPerson = @"DROP PROCEDURE [dbo].[UpdateAPerson]";
            migrationBuilder.Sql(sp_UpdateAPerson);
        }
    }
}

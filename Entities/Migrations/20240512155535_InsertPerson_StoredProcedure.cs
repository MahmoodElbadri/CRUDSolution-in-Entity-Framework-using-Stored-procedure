using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    public partial class InsertPerson_StoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sp_InsertAPerson = @"
                CREATE PROCEDURE [dbo].[InsertAPerson] (
                    @PersonIdD uniqueidentifier,
                    @PersonName nvarchar(40),
                    @Email nvarchar(40),
                    @DateOfBirth datetime,
                    @Gender varchar(10),
                    @CountryID uniqueidentifier,
                    @Address varchar(200),
                    @ReceiveNewsLetters bit)
                        AS 
                        BEGIN
                            INSERT INTO [dbo].[Persons] (PersonID, PersonName, Email, DateOfBirth, Gender, CountryID, Address, ReceiveNewsLetters) 
                            VALUES (@PersonIdD, @PersonName, @Email, @DateOfBirth, @Gender, @CountryID, @Address, @ReceiveNewsLetters)
                        END
                ";
            migrationBuilder.Sql(sp_InsertAPerson);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sp_InsertAPerson = @"
                DROP PROCEDURE [dbo].[InsertAPerson]
                ";
            migrationBuilder.Sql(sp_InsertAPerson);
        }
    }
}

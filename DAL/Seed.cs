using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestsForShabat.DAL
{
    internal static class Seed
    {
        private static string _connectionString;
		public static string InitializeDB(string connStr)
        {
            _connectionString = connStr;
            DBContext db = new DBContext(_connectionString);
            string query = @"use ShabatDB

BEGIN TRANSACTION;

BEGIN TRY
	declare @answer varchar(20) = 'לא היה צריך'
	
	if not exists (select * from sys.tables where Name = 'Guests')
	begin
	set @answer = 'היה צורך'
	create table Guests(
		ID int primary key identity,
		Name varchar(100) unique not null
	)
	end

	if not exists (select * from sys.tables where Name = 'Categories')
	begin
	set @answer = 'היה צורך'
	create table Categories(
		ID int primary key identity,
		Name varchar(100) unique not null
	)
	end

	if not exists (select * from sys.tables where Name = 'Food')
	begin
	set @answer = 'היה צורך'
	create table Food(
		ID int primary key identity,
		Guest_ID int foreign key references Guests(ID),
		Category_ID int foreign key references Categories(ID),
		Name varchar(100) not null
	)
	end

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;

END CATCH;

SELECT @answer
";
			return (string)db.ExecuteScalar(query, null);
        }
    }
}

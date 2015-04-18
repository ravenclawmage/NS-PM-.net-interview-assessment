/*
The Interview database should be created as a local db file in the App_Data folder. This should be attached to your (LocalDB)\v11.0 instance.
Since local databases often have trouble being shared between computers, we'll create the database fresh.
	1.	Right click the App_Data folder, and select Add -> New Item -> SQL Server Database -> name it Interview.mdf
	2.	You should be able to find a new connetion to this database under Server Explorer. Right click and choose New Query, and run the script below

Some helpful commands for working with the SqlLocalDB Utility reside here https://msdn.microsoft.com/en-us/library/hh212961.aspx
*/

if object_id('Contacts') is null
begin
	create table [dbo].[Contacts](
		[ContactId] [int] IDENTITY(1,1) NOT NULL
			constraint [PK_Contacts] primary key clustered,
		[FirstName] [varchar](50) NOT NULL,
		[LastName] [varchar](50) NOT NULL,
		[Email] [varchar](50) NOT NULL,
		[Phone] [varchar](50) NOT NULL,
		[GenderId] [int] NOT NULL)
end
go

if not exists(select * from Contacts)
begin
	insert into Contacts(FirstName, LastName, Email, Phone, GenderId) values
		 ('Adelaide', 'Stitch', 'astitch@nannymcphee.com', '(801) 355-5355', 2)
		,('Mickey', 'Mouse', 'mickymouse@disney.com', '(610) 913-2218', 1)
		,('Minnie', 'Mouse', 'minniemouse@disney.com', '(435) 555-2525', 2)
		,('Clark', 'Kent', 'superman@marvelcomics.com', '(690) 189-2525', 1)
		,('Joan', 'Arc', 'joanofarc@billandteds.com', '(953) 890-3768', 2)
end
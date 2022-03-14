
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PricingToolDB')
BEGIN
  CREATE DATABASE [PricingToolDB]
END
GO

USE PricingToolDB
GO

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  TABLE_NAME = 'Proposals'))
BEGIN
CREATE TABLE PricingToolDB.dbo.Proposals
(	
	ID int Primary Key identity(1,1),
	ProposalName varchar(100) unique not null,
	CustomerGrpName varchar(100),
	[Date] datetime,
	[Description] varchar(200),
	[Status] varchar(50)
)
END

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  TABLE_NAME = 'Facilities'))
BEGIN
CREATE TABLE PricingToolDB.dbo.Facilities
(
	ID INT Primary Key identity(1,1),
	ProposalName varchar(100) FOREIGN KEY REFERENCES PricingToolDB.dbo.Proposals(ProposalName),
	FacilityName varchar(100),
	BookingCountry varchar(100),
	Currency varchar(50),
	StartDate datetime,
	MaturityDate datetime,
	Limit numeric
)
END




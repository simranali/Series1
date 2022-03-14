-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spPricingToolProposals 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    
	SELECT * FROM dbo.Proposals p
	ORDER BY p.ProposalName

END
GO

CREATE PROCEDURE dbo.spPricingToolFacilities 
	@proposalName nvarchar(100),
	@facilityName nvarchar(100) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from dbo.Facilities where 
	ProposalName = @proposalName 
	AND (@facilityName is null OR @facilityName = FacilityName)
	ORDER BY FacilityName
END
GO
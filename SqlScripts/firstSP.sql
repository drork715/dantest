USE [DrorTest]
GO

/****** Object:  StoredProcedure [dbo].[a_sp_firstQuery]    Script Date: 07/04/2022 18:11:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[a_sp_firstQuery]

@year int 

AS
BEGIN


declare @qfirst as datetime= DATEADD(q, 0,CAST(@year AS varchar)) 
declare @qlast as datetime=DATEADD(q, 1,CAST(@year AS varchar))

select top 1  [AGENT_CODE] --,sum([ADVANCE_AMOUNT])  
	from [dbo].[ORDERS]
	where [ORD_DATE] between @qfirst and @qlast

	group by AGENT_CODE 
	order by sum([ADVANCE_AMOUNT]) desc
	

  


END

GO



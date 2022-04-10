USE [DrorTest]
GO

/****** Object:  StoredProcedure [dbo].[a_sp_secondQuery]    Script Date: 07/04/2022 18:12:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[a_sp_secondQuery]
@list varchar(max),
@orderNum int 

AS
BEGIN

WITH MyCte AS 
(
SELECT ORD_NUM, ORD_AMOUNT, ADVANCE_AMOUNT, ORD_DATE, CUST_CODE, AGENT_CODE, ORD_DESCRIPTION ,
	  id=ROW_NUMBER() OVER(PARTITION BY [AGENT_CODE] ORDER BY [ORD_DATE] ) 
  FROM [DrorTest].[dbo].[ORDERS] 
  where agent_code in (select Id from dbo.splitstring(@list))
)

  select ORD_NUM, ORD_AMOUNT, ADVANCE_AMOUNT, ORD_DATE, CUST_CODE, AGENT_CODE, ORD_DESCRIPTION from MyCte
  where id=@orderNum

	

  


END

GO



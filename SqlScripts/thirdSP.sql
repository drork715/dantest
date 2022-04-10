USE [DrorTest]
GO
/****** Object:  StoredProcedure [dbo].[a_sp_thirdQuery]    Script Date: 07/04/2022 18:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[a_sp_thirdQuery]
@number int,
@year int 

AS
BEGIN

select  o.AGENT_CODE,AGENT_NAME,PHONE_NO
	from 
		[dbo].[ORDERS] o left join [dbo].[AGENTS] a on o.AGENT_CODE=a.AGENT_CODE
		where year([ORD_DATE])=@year
	group by o.AGENT_CODE , a.AGENT_NAME , a.PHONE_NO 
	having count(ORD_NUM)>=@number


END


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class orderDTO
    {
        public int ORD_NUM;
        public float ORD_AMOUNT;
        public float ADVANCE_AMOUNT;
        public DateTime ORD_DATE;
        public string CUST_CODE;
        public string AGENT_CODE;
        public string ORD_DESCRIPTION;
    }

    public class agentDTO
    {
        public string AGENT_CODE;
        public string AGENT_NAME;
        public string PHONE_NO;
    }




}
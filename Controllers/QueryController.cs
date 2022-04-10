
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using webapi.Dal;
using webapi.Models;

namespace webapi.Controllers
{

    [System.Web.Http.Cors.EnableCors("*","*","*")]
    [RoutePrefix("api/Query")]
    public class QueryController : ApiController
    {
        [HttpGet]
        [Route("FirstQuery")]
        public async Task<string> FirstQuery([FromUri] int year)
        {

            try
            {
                var dal = new DalDapper();
                return await dal.FirstQuery(year);


            }
            catch (Exception ex)
            {
                return ex.ToString();
            }


        }

        [HttpPost]
        [Route("SecondQuery")]
        public async Task<IEnumerable<orderDTO>> SecondQuery([FromBody] SecondQueryDTO obj)
        {

                var dal = new DalDapper();
                return await dal.SecondQuery(obj.list,obj.orderNum);

        }
        [HttpPost]
        [Route("ThirdQuery")]
        public async Task<IEnumerable<agentDTO>> ThirdQuery([FromBody] ThirdQueryDTO obj)
        {

            var dal = new DalDapper();
            var res = (await dal.ThirdQuery(obj.number, obj.year)).ToList();
            res.ForEach(x => x.AGENT_NAME = x.AGENT_NAME.Trim());
            return res;

        }
    }
}

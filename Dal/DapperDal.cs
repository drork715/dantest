using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using webapi.Models;

namespace webapi.Dal
{
    public  class DalDapper
    {


        public async Task<string> FirstQuery(int year)
        {

            var Connection = common.connectionString;
            using (var connection = new SqlConnection(Connection))
            {
                await connection.OpenAsync();
                return await connection.QuerySingleAsync<string>("dbo.a_sp_firstQuery",
                                new { year },
                                commandType: CommandType.StoredProcedure);
            }
          
        }

        public async Task<IEnumerable<orderDTO>> SecondQuery(string list,int orderNum)
        {

            var Connection = common.connectionString;
            using (var connection = new SqlConnection(Connection))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<orderDTO>("dbo.a_sp_secondQuery",
                                new { list, orderNum },
                                commandType: CommandType.StoredProcedure);
            }

        }

        public async Task<IEnumerable<agentDTO>> ThirdQuery(int number, int year)
        {

            var Connection = common.connectionString;
            using (var connection = new SqlConnection(Connection))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<agentDTO>("dbo.a_sp_thirdQuery",
                                new { number, year },
                                commandType: CommandType.StoredProcedure);
            }

        }
    }
}
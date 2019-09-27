using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.Json;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace aws_lambda_netcore3_dapper
{
    public class Function
    {
        private static async Task Main(string[] args)
		{
            Func<ILambdaContext, Task<List<Member>>> func = FunctionHandler;
			using(var handlerWrapper = HandlerWrapper.GetHandlerWrapper(func, new JsonSerializer()))
			{
				using(var lambdaBootstrap = new LambdaBootstrap(handlerWrapper))
				{
					await lambdaBootstrap.RunAsync();
				}
			}
		}

        public static async Task<List<Member>> FunctionHandler(ILambdaContext context)
        {
            using (MySqlConnection _connection = new MySqlConnection(LambdaConfiguration.Instance["DB_CONNECTION"].ToString()))  
            {  
                context.Logger.LogLine("_connection.ConnectionString: " + _connection.ConnectionString);
                context.Logger.LogLine("_connection.ToString: " + _connection.ToString());

                if (_connection.State == ConnectionState.Closed)  
                    _connection.Open();  
                
                context.Logger.LogLine("ServerVersion After Open: " + _connection.ServerVersion + "\nState: " + _connection.State.ToString());

                string sqlQuery = "SELECT * FROM test_member";
                var result = await _connection.QueryAsync<Member>(sqlQuery);
                
                return result.ToList();  
            } 
        }
    }
}

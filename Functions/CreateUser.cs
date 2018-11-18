using System.Threading.Tasks;
using azure_test.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace azure_test.Functions
{
    public static class CreateUser
    {
        [FunctionName("CreateUser")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] [FromBody] CreateUserQuery user,
            ILogger log)
        {
            CreateUserQueryHandler createUserQueryHandler = new CreateUserQueryHandler();
            log.LogInformation("C# HTTP trigger function processed a request.");

            return  new CreatedResult("here",await createUserQueryHandler.ExecuteAsync(user));
        }
    }
}

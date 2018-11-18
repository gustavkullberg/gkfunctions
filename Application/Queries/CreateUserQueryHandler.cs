using System.Threading.Tasks;
using azure_test.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace azure_test.Application.Queries
{
    public class CreateUserQueryHandler{

        public CreateUserQueryHandler()
        {
            
        }

        public async Task<User> ExecuteAsync(CreateUserQuery query)
        {

            return new User(query.Name, query.Email, query.Password);

        }
    }
}
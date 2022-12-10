using CQRSPattern.QueryOperation.Users;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersQueryController : ControllerBase
    {
        private readonly IUsersQuery _usersQuery;
       public UsersQueryController(IUsersQuery usersQuery)
        {
            _usersQuery = usersQuery;
        }

        [HttpGet]
        public dynamic Get()
        {
            return _usersQuery.Get();
        }
    }
}

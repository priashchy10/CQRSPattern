using Microsoft.AspNetCore.Mvc;
using CQRSPattern.Model;
using CQRSPattern.CommandOperation.Users;

namespace CQRSPattern.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersCommandController : ControllerBase
    {
        private readonly IUsersCommand _usersCommand;
        public UsersCommandController(IUsersCommand usersCommand)
        {
            _usersCommand = usersCommand;
        }
        [HttpPost]
        public async Task<dynamic> Save(User user)
        {
            return await _usersCommand.Save(user);
        }
    }
}

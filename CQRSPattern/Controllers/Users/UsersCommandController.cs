using Microsoft.AspNetCore.Mvc;
using CQRSPattern.CommandOperation.Users;
using Infrastructure.Persistence;
using Application.CommandOperation.Users;

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
        public async Task<dynamic> Save(UsersCommandDTO userCommandDto)
        {
            return await _usersCommand.Save(userCommandDto);
        }
    }
}

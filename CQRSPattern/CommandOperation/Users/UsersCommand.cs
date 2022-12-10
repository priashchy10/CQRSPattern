using CQRSPattern.Model;
using CQRSPattern.Repository.Users;

namespace CQRSPattern.CommandOperation.Users
{
    public class UsersCommand:IUsersCommand
    {
        private readonly IUsersCommandRepository _usersCommandRepository;
        public UsersCommand(IUsersCommandRepository usersCommandRepository)
        {
            _usersCommandRepository = usersCommandRepository;
        }

        public async Task<dynamic> Save(User user)
        {
            return await _usersCommandRepository.Save(user);
        }
    }
}

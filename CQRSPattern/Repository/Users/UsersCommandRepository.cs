using CQRSPattern.DataAccess.Users;
using CQRSPattern.Model;

namespace CQRSPattern.Repository.Users
{
    public class UsersCommandRepository: IUsersCommandRepository
    {
        private readonly IUsersCommandDataAccess _usersCommandDataAccess;
        public UsersCommandRepository(IUsersCommandDataAccess usersCommandDataAccess)
        {
            _usersCommandDataAccess = usersCommandDataAccess;
        }

        public async Task<dynamic> Save(User user)
        {
           return await _usersCommandDataAccess.Save(user);
        }

    }
}

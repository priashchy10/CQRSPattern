using CQRSPattern.DataAccess.Users;

namespace CQRSPattern.Repository.Users
{
    public class UsersQueryRepository: IUsersQueryRepository
    {
        private readonly IUsersQueryDataAccess _usersQueryDataAccess;
        public UsersQueryRepository(IUsersQueryDataAccess usersQueryDataAccess)
        {
            _usersQueryDataAccess = usersQueryDataAccess;
        }

        public dynamic Get()
        {
            return  _usersQueryDataAccess.Get();
        }
    }
}

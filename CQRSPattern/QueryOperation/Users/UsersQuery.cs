using CQRSPattern.Repository.Users;

namespace CQRSPattern.QueryOperation.Users
{
    public class UsersQuery: IUsersQuery
    {
        private readonly IUsersQueryRepository _usersQueryRepository;
        public UsersQuery(IUsersQueryRepository usersQueryRepository)
        {
            _usersQueryRepository = usersQueryRepository;
        }

        public dynamic Get()
        {
            return _usersQueryRepository.Get();
        }
    }
}

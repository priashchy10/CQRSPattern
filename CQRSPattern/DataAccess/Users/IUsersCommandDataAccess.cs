using CQRSPattern.Model;

namespace CQRSPattern.DataAccess.Users
{
    public interface IUsersCommandDataAccess
    {
        Task<dynamic> Save(User users);
    }
}

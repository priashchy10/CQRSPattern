using CQRSPattern.Model;

namespace CQRSPattern.Repository.Users
{
    public interface IUsersCommandRepository
    {
        Task<dynamic> Save(User user);
    }
}

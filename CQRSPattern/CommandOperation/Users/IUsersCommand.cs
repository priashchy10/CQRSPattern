using CQRSPattern.Model;
namespace CQRSPattern.CommandOperation.Users
{
    public interface IUsersCommand
    {
        Task<dynamic> Save(User user);
    }
}

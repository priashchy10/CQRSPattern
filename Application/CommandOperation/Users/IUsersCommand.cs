using Application.CommandOperation.Users;
using Infrastructure.Persistence;

namespace CQRSPattern.CommandOperation.Users
{
    public interface IUsersCommand
    {
        Task<dynamic> Save(UsersCommandDTO userCommandDto);
    }
}

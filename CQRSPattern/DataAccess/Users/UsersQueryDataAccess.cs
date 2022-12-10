using CQRSPattern.Model;

namespace CQRSPattern.DataAccess.Users
{
    public class UsersQueryDataAccess: IUsersQueryDataAccess
    {
        private readonly CqrspatternContext _context;
        public UsersQueryDataAccess(CqrspatternContext context)
        {
            _context = context;
        }

        public dynamic Get()
        {
            try
            {
               return _context.Set<User>();
            }
            catch (Exception ex)
            {
                return ex.InnerException;
            }
        }
    }
}

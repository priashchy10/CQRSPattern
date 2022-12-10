using CQRSPattern.Model;

namespace CQRSPattern.DataAccess.Users
{
    public class UsersCommandDataAccess : IUsersCommandDataAccess
    {
        private readonly CqrspatternContext _context;
        public UsersCommandDataAccess(CqrspatternContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Save(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                var count = _context.SaveChanges();
                if (count > 0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Save failed";
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

    }
}

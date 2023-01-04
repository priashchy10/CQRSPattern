using Application.CommandOperation.Users;
using Infrastructure.Persistence;

namespace CQRSPattern.CommandOperation.Users
{
    public class UsersCommand:IUsersCommand
    {
        private readonly CqrspatternContext _context;
        public UsersCommand(CqrspatternContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Save(UsersCommandDTO userCommandDto)
        {
            try
            {
                User user = new User
                {
                    Name = userCommandDto.Name,
                    Email = userCommandDto.Email,   
                    Phone = userCommandDto.Phone,
                    Address = userCommandDto.Address,
                };

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

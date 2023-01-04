//using CQRSPattern.Repository.Users;

using Application.QueryOperation.Users;
using Infrastructure.Persistence;

namespace CQRSPattern.QueryOperation.Users
{
    public class UsersQuery : IUsersQuery
    {
        private readonly CqrspatternContext _context;
        public UsersQuery(CqrspatternContext context)
        {
            _context = context;
        }

        public dynamic GetAll()
        {
            var users = _context.Users.ToList();

            if (users is null)
                return null;

            var results = new List<dynamic>();
            foreach (var obj in users)
            {
                UsersDisplayDTO usersDisplayDTO = new UsersDisplayDTO()
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    Phone = obj.Phone,
                    Address = obj.Address,
                    Email = obj.Email,
                };
                results.Add(usersDisplayDTO);
            }
            return results;
        }
    }
}

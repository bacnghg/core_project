using System;
using coreHR.Models;

namespace coreHR.Repository
{
	public class UserRepository : IUserRepository
	{
        private readonly ProductDbContext _dbContext;

		public UserRepository(ProductDbContext context)
		{
            _dbContext = context;
		}

        public void DeleteUser(int userId)
        {
            var user = _dbContext.User.Find(userId);
            _dbContext.User.Remove(user);
            Save();
        }

        public Users GetUserByID(int userId)
        {
            return _dbContext.User.Find(userId);
        }

        public IEnumerable<Users> GetUsers()
        {
            return _dbContext.User.ToList();
        }

        public void InsertUser(Users user)
        {
            _dbContext.Add(user);
            Save();
        }

        public void Save()
        {
            return _dbContext.SaveChanges();
        }

        public void UpdateUser(Users user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            Save();
        }
    }
}


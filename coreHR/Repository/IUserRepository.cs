using System;
using coreHR.Models;
namespace coreHR.Repository
{
	public interface IUserRepository
	{
		IEnumerable<Users> GetUsers();
		Users GetUserByID(int userId);
		void InsertUser(Users user);
		void DeleteUser(int userId);
		void UpdateUser(Users user);
		void Save();
    }
}


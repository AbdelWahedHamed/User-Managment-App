using BlazorUMA.Models;

namespace BlazorUMA.Services
{
	public interface IUserService
	{
		List<User> GetUsers();
		void AddUser(User user);
		void DeleteUser (User user);
		bool GetUserEmailAndPassword(string email , string password);
	}
}

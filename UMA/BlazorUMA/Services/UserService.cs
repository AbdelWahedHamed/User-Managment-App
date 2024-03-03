using Azure.Core;
using BlazorUMA.Data;
using BlazorUMA.Models;

namespace BlazorUMA.Services
{
	public class UserService : IUserService
	{
		private readonly DataContext _context;

		public UserService(DataContext context)
		{
			_context = context;
		}
		public void AddUser(User user)
		{
            Console.WriteLine("I'm in add user");
            _context.Add(user);
			_context.SaveChanges();
		}

		public void DeleteUser(User user)
		{
			_context.Remove(user);
			_context.SaveChanges();
		}

		public bool GetUserEmailAndPassword(string email, string password)
		{
			if(_context.Users.FirstOrDefault(x => x.Email == email) != null)
			{
				if(_context.Users.FirstOrDefault(x => x.Password == password) != null)
				{ return true; }
				return false;
			}
			return false;
		}

		public List<User> GetUsers()
		{
			return _context.Users.OrderBy(p => p.Id).ToList();
		}
	}
}

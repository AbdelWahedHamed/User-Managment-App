using Azure.Core;
using BlazorUMA.Data;
using BlazorUMA.Models;

namespace BlazorUMA.Services
{
	public class RoleService : IRoleService
	{
		//public List<Role> roles = new List<Role>();
		private readonly DataContext _context;

		public RoleService(DataContext context)
		{
			_context = context;
		}

		//private readonly HttpClient _http;
		//public RoleService(HttpClient http)
		//{
		//	_http = http;
		//}
		public  List<Role> GetRoles()
		{
			return  _context.Roles.OrderBy(p => p.Id).ToList();

			//return await _http.GetFromJsonAsync<List<Role>>("api/Role");
		}

		public  Role GetRole(int id)
		{
			return _context.Roles.FirstOrDefault(r => r.Id == id);
		}

		public bool AddRole(Role role)
		{
			_context.Roles.Add(role);
			_context.SaveChanges();
			return true;
		}

		public bool DeleteRole(Role role)
		{
			_context.Roles.Remove(role);
			_context.SaveChanges();
			return true;

		}

		
	}
}

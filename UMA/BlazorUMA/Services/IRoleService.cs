using BlazorUMA.Models;

namespace BlazorUMA.Services
{
	public interface IRoleService
	{
		public List<Role> GetRoles();
		Role GetRole(int id);
		bool AddRole(Role role);
		bool DeleteRole(Role role);

	}
}

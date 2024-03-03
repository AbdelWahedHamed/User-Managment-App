using BlazorUMA.Data;
using BlazorUMA.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorUMA.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoleController : ControllerBase
	{
		private readonly DataContext _context;

		public RoleController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<List<Role>> GetRoles()
		{
			return Ok(_context.Roles.OrderByDescending(p => p.Id));
		}

		[HttpGet("{Id}")]
		public ActionResult<Role> GetRole(int id)
		{
			var role = _context.Roles.FirstOrDefault(p => p.Id == id );
			if (role == null)
			{
				return NotFound();
			}

			return Ok(role);
		}


		[HttpPost]
		public async Task<ActionResult<Role>> CreateRole(Role role)
		{
			_context.Add(role);
			await _context.SaveChangesAsync();

			return role;
		}

	}
}

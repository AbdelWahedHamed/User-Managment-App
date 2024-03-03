using System.ComponentModel.DataAnnotations;

namespace BlazorUMA.Models
{
	public class Role
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Required Field")]
		public string RoleName { get; set; }
		public List<User> Users { get; set; }
	}
}

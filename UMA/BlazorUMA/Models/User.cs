using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BlazorUMA.Models
{
	public class User
	{

		public int Id { get; set; }

		[Required (ErrorMessage ="Required Field")]
		public string Name { get; set; }

		[EmailAddress (ErrorMessage ="Invalid Email")]
		[Required(ErrorMessage = "Required Field")]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		[Required (ErrorMessage ="Enter a password")]
		public string Password { get; set; }

		public DateTime DateOfBirth { get; set; }
		public DateTime RegisterationDate { get; set; } = DateTime.Now;

		public int RoleId { get; set; }
        public Role Role { get; set; }
	}
}

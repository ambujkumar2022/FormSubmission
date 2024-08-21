using System.ComponentModel.DataAnnotations;

namespace FormSubmission.ViewModels
{
	public class Register
	{
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		[Compare(nameof(Password), ErrorMessage = "Password and Configuration password did not match")]
		public string ConfirmPassword { get; set;}
	}
}

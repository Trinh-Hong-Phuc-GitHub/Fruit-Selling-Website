using System.ComponentModel.DataAnnotations;

namespace FruitSellingWebsite.Models.ViewModels
{
	public class LoginViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Nhập UserName")]
		public string UserName { get; set; }
		[DataType(DataType.Password), Required(ErrorMessage = "Nhập Password")]
		public string Password { get; set; }
		public string ReturnURL { get; set; }
	}
}

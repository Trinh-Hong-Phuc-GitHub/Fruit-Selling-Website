using Microsoft.AspNetCore.Identity;

namespace FruitSellingWebsite.Models
{
	public class AppUserModel : IdentityUser
	{
		public string Occupation {  get; set; }
	}
}

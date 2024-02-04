using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Talabat.Core.Entities.Identity;

namespace Talabat.Repository.Identity
{
	public static class AppIdentityDbContextSeed
	{
		public static async Task SeedUserAsync(UserManager<AppUser> userManager)
		{
			if (!userManager.Users.Any())
			{
				var user = new AppUser()
				{
					DisplayNams = "Ahmed Ashraf",
					Email = "ahmedashraf.mail1@gmail.com",
					UserName = "ahmedashraf",
					PhoneNumber = "01013893864",
				};

				await userManager.CreateAsync(user, "P@ssw0rd");
			}

		}
	}
}

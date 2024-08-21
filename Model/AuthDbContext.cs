using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormSubmission.Model
{
	public class AuthDbContext : IdentityDbContext<IdentityUser>
	{
		public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options)
		{

		}
	}

	public class AuthDbContextFactory : IDesignTimeDbContextFactory<AuthDbContext>
	{		public AuthDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AuthDbContext>();
			optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=AspNetAuth;Trusted_Connection=True;Integrated Security=True");
			//optionsBuilder.UseSqlServer("AuthConnString");
			return new AuthDbContext(optionsBuilder.Options);
		}
	}
}

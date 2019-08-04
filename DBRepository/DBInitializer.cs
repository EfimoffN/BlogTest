using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBRepository
{
	public static class DbInitializer
	{
		public async static Task Initialize(RepositoryContext context)
		{
			await context.Database.MigrateAsync();

            Tag t = new Tag() { PostId = 1, TagId = 1, TagName = "Test"};

            var userCount = await context.Users.CountAsync().ConfigureAwait(false);
			if (userCount == 0)
			{
				context.Users.Add(new Models.User()
				{
                    Login = "admin",
                    Password = "JRKhb2Ty49MIM2If056pD2U2P5gOZ5l5KsliQMPFTyk=", // testblog
                    isAdmin = true
                });
                context.Posts.Add(new Models.Post()
                {
                    Header = "Test",
                    Body = "Test Test Test",
                    CreatedDate = DateTime.Now
                });

                await context.SaveChangesAsync().ConfigureAwait(false);
			}
		}
	}
}

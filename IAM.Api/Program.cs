using IAM.Api.Data;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IAM.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args)
				.MigrateDbContext<PersistedGrantDbContext>((_, __) => { })
				.MigrateDbContext<ApplicationDbContext>((context, services) =>
				{
					var env = services.GetService<IHostingEnvironment>();
					var logger = services.GetService<ILogger<ApplicationDbContextSeed>>();
					var settings = services.GetService<IOptions<AppSettings>>();

					new ApplicationDbContextSeed()
						.SeedAsync(context, env, logger, settings)
						.Wait();
				})
				.MigrateDbContext<ConfigurationDbContext>((context, services) =>
				{
					var configuration = services.GetService<IConfiguration>();

					new ConfigurationDbContextSeed()
						.SeedAsync(context, configuration)
						.Wait();
				}).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseKestrel()
				.UseStartup<Startup>()
				.Build();
	}
}

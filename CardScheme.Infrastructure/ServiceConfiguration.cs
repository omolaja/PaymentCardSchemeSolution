using System;
using CardScheme.Applications.Repositories;
using CardScheme.Infrastructure.AppContext;
using CardScheme.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CardScheme.Infrastructure
{
	public static class ServiceConfiguration
	{
		public static IServiceCollection InfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			return services
				.AddTransient<ICustomers, CustomerRepo>()
				.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CardShemeDatabase")));
		}
	}
}


using System;
using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CardScheme.Applications
{
	public static class ServiceConfigurations
	{
		public static IServiceCollection ApplicationServices(this IServiceCollection services)
		{
			return services.AddAutoMapper(Assembly.GetExecutingAssembly())
				.AddMediatR(Assembly.GetExecutingAssembly())
				.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}


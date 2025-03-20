using System;
using CardScheme.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CardScheme.Infrastructure.AppContext
{
	public class AppDbContext : DbContext
	{
		DbSet<Customers> customers { get; set; }
	}
}


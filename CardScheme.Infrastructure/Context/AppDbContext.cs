using System;
using CardScheme.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CardScheme.Infrastructure.AppContext
{
<<<<<<< Updated upstream
	       public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
=======
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
>>>>>>> Stashed changes
		{

		}

		public DbSet<Customers> Customers { get; set; }

		public DbSet<Gender> Gender { get; set; }

		public DbSet<CardTypes> CardTypes { get; set; }

		public DbSet<CustomerAddress> CustomerAddresses { get; set; }

		public DbSet<CustomerCards> CustomerCards { get; set; }
<<<<<<< Updated upstream
=======
	}
>>>>>>> Stashed changes
}


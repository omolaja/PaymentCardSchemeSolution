using System;
namespace CardScheme.Domain.Entity
{
	public class CustomerAddress
	{
		public int Id { get; set; }

		public string Address { get; set; }

		public int CustomerId { get; set; }

		public Customers customers { get; set; }
	}
}


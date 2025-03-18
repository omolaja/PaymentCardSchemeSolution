using System;
namespace CardScheme.Domain.Entity
{
	public class CustomerCards
	{
		public int Id { get; set; }

		public int CustomerId { get; set; }

		public int CardTypesId { get; set; }

		public string CardPan { get; set; }

		public string Token { get; set; }

		public string CVV { get; set; }

		public string ExpireDate { get; set; }

		public bool IsActive { get; set; }

		public Customers customers { get; set; }

		public CardTypes card { get; set; }
	}
}


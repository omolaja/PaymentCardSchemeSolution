using System;
namespace CardScheme.Domain.Entity
{
	public class CardTypes
	{
		public int Id { get; set; }

		public string CardType { get; set; }

		public string CardCode { get; set; }

		public bool IsActive { get; set; }
	}
}


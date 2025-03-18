using System;
namespace CardScheme.Domain.Entity
{
	public class Customers
	{
		public int Id { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Prefername { get; set; }

		public DateTime DOB { get; set; }

		public int GenderId { get; set; }

		public string Email { get; set; }

		public string Phoneno { get; set; }

		public bool IsEmailEnabled { get; set; }

		public bool IsSmsEnabled { get; set; }

		public DateTime DateCreated { get; set; }

		public bool IsActive { get; set; }

		public Gender gender { get; set; }

		public List<CustomerAddress> customerAddresses { get; set; }

		public List<CustomerCards> customerCards { get; set; }
	}
}


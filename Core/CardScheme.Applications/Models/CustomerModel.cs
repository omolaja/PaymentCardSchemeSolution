using System;
namespace CardScheme.Applications.Models
{
	public class CustomerModel
	{
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Prefername { get; set; }

        public DateTime DOB { get; set; }

        public int GenderId { get; set; }

        public string Email { get; set; }

        public string Phoneno { get; set; }

        public bool IsEmailEnabled { get; set; }

        public bool IsSmsEnabled { get; set; }
     
    }
}


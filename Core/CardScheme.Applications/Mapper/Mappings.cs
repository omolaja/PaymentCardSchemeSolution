using System;
using AutoMapper;
using CardScheme.Applications.Models;
using CardScheme.Domain.Entity;

namespace CardScheme.Applications.Mapper
{
	public class Mappings : Profile
	{
		public Mappings()
		{
			CreateMap<CustomerModel, Customers>();
		}
	}
}


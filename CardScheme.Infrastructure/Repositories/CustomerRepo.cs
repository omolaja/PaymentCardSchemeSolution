using System;
using CardScheme.Applications.Repositories;
using CardScheme.Domain.Entity;
using CardScheme.Infrastructure.AppContext;

namespace CardScheme.Infrastructure.Repositories
{
	public class CustomerRepo : ICustomers
	{
		private readonly AppDbContext _appDbContext;

        public CustomerRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddNewCustomer(Customers customers)
        {
            await _appDbContext.AddAsync(customers);
            await _appDbContext.SaveChangesAsync();
        }

        public Task DisableCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customers>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}


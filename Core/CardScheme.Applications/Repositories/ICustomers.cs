using CardScheme.Domain.Entity;

namespace CardScheme.Applications.Repositories
{
    public interface ICustomers
	{
		Task AddNewCustomer(Customers customers);

		Task<List<Customers>> GetAllCustomers();

		Task GetCustomerById(int Id);

		Task DisableCustomerById(int Id);

		Task UpdateCustomer(Customers customers);
	}
}


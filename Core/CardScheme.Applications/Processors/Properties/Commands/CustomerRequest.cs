using AutoMapper;
using CardScheme.Applications.Models;
using CardScheme.Applications.Repositories;
using CardScheme.Domain.Entity;
using MediatR;

namespace CardScheme.Applications.Processors.Properties.Commands
{
    public class CustomerRequest : IRequest<Response>
	{
		public CustomerModel _customerModel { get; set; }


        public CustomerRequest(CustomerModel customerModel )
        {
            _customerModel = customerModel;
        }
    }


    public class CustomerRequestHandler : IRequestHandler<CustomerRequest, Response>
    {
        private readonly ICustomers _customers;
        private readonly IMapper _mapper;
        private readonly Response _response;

        public CustomerRequestHandler(IMapper mapper, ICustomers customers, Response response)
        {
            _mapper = mapper;
            _customers = customers;
            _response = response;
        }

        public async Task<Response> Handle(CustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customers>(request);

            if(customer != null)
            {
                return _response;
            }

            await _customers.AddNewCustomer(customer);

            return _response;
            
        }
    }
}


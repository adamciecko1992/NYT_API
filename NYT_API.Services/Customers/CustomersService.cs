
using AutoMapper;
using NYT_API.Data;
using NYT_API.Data.Models;
using NYT_API.Services.ViewModels;


namespace NYT_API.Services.Customers
{
    public class CustomersService : ICustomersService
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustomersService(MyDbContext dbcontext, IMapper mapper)
        {
            _dbContext = dbcontext;
            _mapper = mapper;
        }

        public ServiceResponse<string> CreateCustomer(Customer customer)
        {
            return new ServiceResponse<string>
            {
                IsSuccess = true,
                HasErrors = false,
                ErrorMessage = "",
                Data = "sdasd"
            };
        }

        public void DeleteCustomer(Customer customer)
        {
            var response = new ServiceResponse<Customer>
            {
                Data = new Customer { },
                ErrorMessage = "ASD",
                HasErrors = false,
                IsSuccess = true
            };
        }



        public CustomerDTO GetCustomerById(int Id)
        {
            var customer = _dbContext.Customers.Find(Id);
            var serializedCustomer = _mapper.Map<CustomerDTO>(customer);
            return serializedCustomer;
        }
    }
}

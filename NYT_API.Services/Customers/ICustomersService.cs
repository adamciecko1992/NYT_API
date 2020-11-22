using NYT_API.Data.Models;
using NYT_API.Services.ViewModels;


namespace NYT_API.Services.Customers
{
    public interface ICustomersService
    {
        public ServiceResponse<string> CreateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
        public CustomerDTO GetCustomerById(int Id);
            
    }
}

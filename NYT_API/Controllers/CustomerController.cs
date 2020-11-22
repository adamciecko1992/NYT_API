using Microsoft.AspNetCore.Mvc;
using System.Linq;
using NYT_API.Services;
using AutoMapper;
using NYT_API.Data.Models;
using NYT_API.Data;
using Microsoft.EntityFrameworkCore;
using NYT_API.Services.ViewModels;

namespace NYT_API.Controllers
{
    [ApiController]
    public class CustomerController
    {
        private readonly IMapper _mapper;
        private readonly MyDbContext _dbContext;
        public CustomerController(IMapper mapper,MyDbContext dbContext )
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }



        [HttpGet("/api/customers/{Id}")]
        public CustomerDTO GetCustomerById(int Id)
        {
            var customer= _dbContext.Customers.Find(Id);
            var serializedCustomer = _mapper.Map<CustomerDTO>(customer);
            return serializedCustomer;
        } 



    }
}

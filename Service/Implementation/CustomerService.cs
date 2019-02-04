using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Dtos;
using Service.Interfaces;
using Core.Interfaces;
using Core.Entities;
using AutoMapper;
using Service.Helpers;

namespace Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CustomerDto> GetAllCustomers()
        {
            IEnumerable<Customer> customers = _unitOfWork.Customers.GetAll();
            var customersToReturn = Mapping.Mapper.Map<IEnumerable<CustomerDto>>(customers);
            return customersToReturn;
        }
    }
}

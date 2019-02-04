using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Interfaces;
using Service.Dtos;


namespace Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ActionResult Index()
        {

            IEnumerable<CustomerDto> customers = _customerService.GetAllCustomers();

            return View(customers);
        }
    }
}
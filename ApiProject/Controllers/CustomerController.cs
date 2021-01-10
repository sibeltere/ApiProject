using ApiProject.Models;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject.Controllers
{
    [Authorize]
    public class CustomerController : ApiController
    {
        #region Fields
        private readonly ICustomerService _customerService;
        #endregion

        #region CTOR
        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public List<CustomerModel> GetCustomerList()
        {
            var customerList = new List<CustomerModel>();
                
            var serviceResponse=_customerService.GetCustomerList();

            foreach (var item in serviceResponse)
            {
                var model = new CustomerModel()
                {
                    Id=item.Id,
                    Name=item.Name,
                    Surname=item.Surname,
                    Age=item.Age
                };

                customerList.Add(model);
            }

            return customerList;
        }
        #endregion

    }
}

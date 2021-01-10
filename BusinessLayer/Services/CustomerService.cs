using BusinessLayer.Interfaces;
using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomerList()
        {
            var customerList = new List<Customer>();

            customerList.Add(new Customer() { Id = 1, Name = "Sibel", Surname = "Tere", Age = 25 });
            customerList.Add(new Customer() { Id = 2, Name = "Fatih", Surname = "San", Age = 28 });
            customerList.Add(new Customer() { Id = 3, Name = "Ahmet", Surname = "Yılmaz", Age = 35 });
            customerList.Add(new Customer() { Id = 4, Name = "Selen", Surname = "Soy", Age = 42 });
            customerList.Add(new Customer() { Id = 5, Name = "Serkan", Surname = "Gürol", Age = 35 });

            return customerList;
        }
    }
}

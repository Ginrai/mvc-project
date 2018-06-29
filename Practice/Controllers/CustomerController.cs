using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customer()
        {
            Customer cust = new Customer();
            
            ViewBag.Message = "Testing ViewBag...";
            var CustomerName = new Customer() { Name = "Pussy" };
            var customers = new List<Customer>()
            {
                new Customer { Name = "Custmer 1" },
                new Customer { Name = "Customer 2" }

            };
            cust.Count = customers;
           // ViewBag.customers = cust.Count;
            return View(cust);
        }

    }
}
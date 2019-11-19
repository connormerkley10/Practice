using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> lstCustomers = new List<Customer>();

        // GET: Customer
        public ActionResult ShowCustomers()
        {
            return View(lstCustomers);
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer myCustomer)
        {
            if (ModelState.IsValid)
            {
                myCustomer.Customer_Code = lstCustomers.Count() + 1;
                lstCustomers.Add(myCustomer);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myCustomer);
            }
        }

        [HttpGet]
        public ActionResult EditCustomer(int sCode)
        {
            Customer oCustomer = lstCustomers.Find(x => x.Customer_Code == sCode);
            return View(oCustomer);
        }

        [HttpPost]
        public ActionResult EditCustomer(Customer myCustomer)
        {
            var obj = lstCustomers.FirstOrDefault(x => x.Customer_Code == myCustomer.Customer_Code);

            if (obj != null)
            {
                obj.Customer_Code = myCustomer.Customer_Code;
                obj.Customer_First_Name = myCustomer.Customer_First_Name;
                obj.Customer_Last_Name = myCustomer.Customer_Last_Name;
                obj.Customer_Email = myCustomer.Customer_Email;
            }

            return RedirectToAction("Index", "Home");
        }



    }
}
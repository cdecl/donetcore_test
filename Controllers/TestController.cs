using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Customer c = new Customer();
            c.No = "1";
            c.Name = "cdecl";

            ViewData["Customer"] = c;
            return View();
        }

        public List<Customer> api()
        {
            var list = new List<Customer>();

            for (int i = 0; i < 10; ++i)
            {
                Customer c = new Customer();
                c.No = i.ToString();
                c.Name = string.Format("bk kim : {0}", DateTime.Now.Millisecond.ToString());

                list.Add(c);

                // Thread.Sleep(10);
            }
            return list;
        }

        // 
        // GET: /Test/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
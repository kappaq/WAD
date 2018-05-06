using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Controllers
{
    public class CustomerController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }
        public ActionResult AddToCart()
        {
            return View();
        }
        public ActionResult OrderDetails()
        {
            return View();
        }
        public ActionResult PlaceOrder()
        {
            return View();
        }


    }
}

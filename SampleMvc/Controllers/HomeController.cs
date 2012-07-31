using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC!";

			return View();
		}

		public ActionResult Status(String name)
		{

			var person = new ordersEntities().Customers.Where(c => c.Name == name).SingleOrDefault(); 
			return View(person);
		}

		public ActionResult About()
		{
			return View();
		}
	}
}

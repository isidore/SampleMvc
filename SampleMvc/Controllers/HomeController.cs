using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvc.Controllers
{
	public partial class  HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC!";

			return View();
		}

		public ActionResult Status(String name)
		{
			var person = new ordersEntities().Customers.Where(c => c.Name == name).SingleOrDefault();
			return Status(person);
		}

		private ActionResult Status(Customer person)
		{
			return View("Status",person);
		}

		public ActionResult About()
		{
			return View();
		}

	}
}

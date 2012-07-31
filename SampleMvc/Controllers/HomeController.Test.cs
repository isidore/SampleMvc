using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
#if DEBUG
namespace SampleMvc.Controllers
{
	public partial class HomeController
	{

		public ActionResult TestStaticVersionOfStatus()
		{
			Customer testSituation = SetupTestSituation();
			return Status(testSituation);
		}

		private Customer SetupTestSituation()
		{
			var lynn = new Customer() { Name = "Lynn" };

			//with 2 completed orders
			var order = new Invoice() { Customer = lynn, Number = "A1201" };
			var item = new InvoiceItem() { Invoice = order, Name = "Hiking Boots", Price = 59.99m, Shipped = true };
			var order1 = new Invoice() { Customer = lynn, Number = "A1202" };
			var item1 = new InvoiceItem() { Invoice = order1, Name = "dress", Price = 159.99m, Shipped = true };

			//2 partial orders and 1 pending order
			order = new Invoice() { Customer = lynn, Number = "A1203" };
			item = new InvoiceItem() { Invoice = order, Name = "Hiking Boots", Price = 9.99m, Shipped = false };
			item = new InvoiceItem() { Invoice = order, Name = "boots", Price = 129.99m, Shipped = true };


			order = new Invoice() { Customer = lynn, Number = "A1205" };
			item = new InvoiceItem() { Invoice = order, Name = "hat", Price = 9.99m, Shipped = false };
			item = new InvoiceItem() { Invoice = order, Name = "watch", Price = 129.99m, Shipped = false };
			return lynn;
		}
	}
}
#endif
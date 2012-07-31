using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMvc;
using SampleMvc.Controllers;

namespace SampleMvc.Tests.Controllers
{
	[TestClass]
	[UseReporter(typeof(TortoiseDiffReporter))]
	public class HomeControllerTest : MvcTest
	{
		
		[TestMethod]
		public void About()
		{
			MvcApprovals.VerifyMvcPage(new HomeController().About);
		}
	}
}

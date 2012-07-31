using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMvc.Controllers;

namespace SampleMvc.Tests.Controllers
{
	[TestClass]
	[UseReporter(typeof(DiffReporter))]
	public class HomeControllerTest : MvcTest
	{
		[TestMethod]
		public void About()
		{
			MvcApprovals.VerifyMvcPage(new HomeController().About);
		}
	}
}
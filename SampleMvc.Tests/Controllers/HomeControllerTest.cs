using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMvc.Controllers;
#if DEBUG
namespace SampleMvc.Tests.Controllers
{
	[TestClass]
	[UseReporter(typeof(FileLauncherReporter), typeof(DiffReporter))]
	public class HomeControllerTest : MvcTest
	{
		[TestMethod]
		public void About()
		{
			MvcApprovals.VerifyMvcPage(new HomeController().About);
		}

		[TestMethod]
		public void TestStaticVersionOfStatus()
		{
			MvcApprovals.VerifyMvcPage(new HomeController().TestStaticVersionOfStatus);
		}
	}
}
#endif
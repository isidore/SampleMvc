using ApprovalTests.Asp;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleMvc.Tests.Controllers
{
	[TestClass]
	[UseReporter(typeof(DiffReporter))]
	public class HomeControllerTest
	{
		[TestMethod]
		public void About()
		{
			AspApprovals.VerifyUrl("http://localhost:50011/Home/About");
		}
	}
}
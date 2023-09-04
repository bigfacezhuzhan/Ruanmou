using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WcfUnitTest.TcpService;

namespace WcfUnitTest
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TestMethod1()
		{
			CompanyServiceClient client = null;
			try
			{
				client = new CompanyServiceClient();
				var users = client.GetListUser();
				client.Close();
			}
			catch (Exception ex)
			{
				if (client != null)
					client.Abort();
				throw ex;
			}
		}
	}
}

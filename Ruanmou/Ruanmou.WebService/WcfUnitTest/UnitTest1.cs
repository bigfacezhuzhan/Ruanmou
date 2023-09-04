using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WcfUnitTest.BigZhanMyWcf;
using WcfUnitTest.MyCompanyService;

namespace WcfUnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//using(BigZhanWcfClient client=new BigZhanWcfClient())
			//{
			//	client.DoWork();
			//	string str= client.GetStr();
			//	var list= client.GetUserList();
			//}
			BigZhanWcfClient client = null;
			CompanyServiceClient client2 = null;
			try
			{
				client = new BigZhanWcfClient();
				client.GetUserList();
				var aniList = client.GetAnimal();

				client2 = new CompanyServiceClient();
				var user= client2.GetUser();
				var list= client2.GetListUser();
				client.Close();
				client2.Close();
			}
			catch (Exception ex)
			{
				if (client != null)
				{
					client.Abort();
				}
				throw ex;
			}
		}
	}
}

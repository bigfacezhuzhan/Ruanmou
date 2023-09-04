using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebService.UnitTest1.BigZhanTestService;

namespace WebService.UnitTest1
{
	[TestClass]
	public class UnitTest1
	{
		[TestInitialize]
		public void Inits()
		{
			Console.WriteLine("Test world");
		}
		[TestMethod]
		public void TestMethod1()
		{
			using(BigShySoapClient client=new BigShySoapClient())
			{
				string h = client.HelloWorld();
				int rs = client.Add(12,22);
				var list= client.GetShys();
			}
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Ruanmou.WebApi.Unit
{

	public class HttpClientFactory
	{
		private static HttpClient httpClient = null;
		static HttpClientFactory()
		{
			httpClient = new HttpClient(new HttpClientHandler());
		}
		public static HttpClient GetHttpClient()
		{
			return httpClient;
		}
	}
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			this.GetClient();
			this.PostClient();
		}

		private void GetClient()
		{
		
			//string url = "http://localhost:12749/userapi/users/GetUserByModel?id=12&name=%E7%8E%8B%E4%BA%94";
			string url = "https://m.maizuo.com/gateway?cityId=440300&pageNum=2&pageSize=10&type=1&k=1942975";
			var handler= new HttpClientHandler();
			var http = HttpClientFactory.GetHttpClient();
			var response= http.GetAsync(url).Result;
			var state = response.StatusCode;
			var rs= response.Content.ReadAsStringAsync().Result;
		}
		private void PostClient()
		{
			Dictionary<string, string> dic = new Dictionary<string, string>();
			dic.Add("users[id]", "123");
			dic.Add("users[name]", "大王");
			dic.Add("info", "This is post client");
			string url = "http://localhost:12749/userapi/users/RegisterUserJData";
			HttpClientHandler handler = new HttpClientHandler();
			var http = HttpClientFactory.GetHttpClient();
			var content= new FormUrlEncodedContent(dic);
			var rs= http.PostAsync(url, content).Result;
			var state= rs.StatusCode;
			string result= rs.Content.ReadAsStringAsync().Result;
		}
	}
}
